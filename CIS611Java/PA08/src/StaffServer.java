/*
 * CIS 611 Programming Assignment PA08
 *
 * Class: StaffServer
 *
 * Purpose: Interface to the Staff database
 *
 * Date Created: 04/18/2019
 *
 * Author: Mary Clark
 */
import java.awt.Container;
import java.io.*;
import java.net.*;
import java.sql.*;
import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.JTextArea;

public class StaffServer extends JPanel {
	static JTextArea log;
	int port;
	private ServerSocket serverSocket;
	private Connection conn = null;
	private Statement stmt = null;
    private Message message = null;
	private PreparedStatement preparedInsert = null;
    private PreparedStatement preparedUpdate = null;
	private ResultSet resultSet = null;
    ObjectInputStream serverInputStream;
	ObjectOutputStream serverOutputStream;
	private final int 	CREATE = 1;
	private final int  	READ = 2;
	private final int 	UPDATE = 3;
	private final int  	DELETE= 4;
    private final int   NOTFOUND = 5;
    private final int   GETCOUNT = 6;
    private final int   LIST = 7;

public StaffServer(int portNum) throws IOException {
	port = portNum;
    try {
    	serverSocket = new ServerSocket(port);
        log.append("--------------------\n");
        log.append("Created Server Socket on port " + port + "\n");
		} catch (IOException ex) {
            log.append("--------------------\n");
            log.append("Failed to create Server Socket on port " + port + " " + ex + "\n");
    	}

    connectDB();
    listenForClients();
}

private void listenForClients() throws IOException {
    while (true) {
        // Listen for a new connection request
        Socket socket = serverSocket.accept();
        log.append("--------------------\n");
        log.append("New client connection accepted from " + socket.getRemoteSocketAddress() + "\n");

        // Create a new thread for the connection
        HandleAClient handler = new HandleAClient(socket);
        // Start the new thread
        new Thread(handler).start();

    }
}

private void connectDB() {
    //String url = "jdbc:mysql://BUSCISMYSQL01/mclark59DB";
    String url = "jdbc:mysql://localhost/PP08";
    try {
     //conn = DriverManager.getConnection(url,"mclark59", "c611c!77536");
     conn = DriverManager.getConnection(url, "root", "root");
    } catch (SQLException ex) {
        log.append("--------------------\n");
        log.append("Unable to connect to " + url + " " + ex + "\n");
        System.exit(-2);
    }
    log.append("--------------------\n");
    log.append("Connected to " + url + "\n");
}

// inner Runnable class to handle a client connection
//class HandleAClient extends Thread {
class HandleAClient implements Runnable {
    private Socket client; // A connected socket

    /* Thread constructor */
    HandleAClient(Socket socket) throws IOException {
        //super("HandleAClient");
        client = socket;
    }

	/** Run a thread */
    @Override
    public void run() {

        try {
            serverInputStream = new ObjectInputStream(client.getInputStream());
            serverOutputStream = new ObjectOutputStream(client.getOutputStream());
        } catch (IOException ex) {
            log.append("--------------------\n");
            log.append("Failed to create server I/O streams \n");
            }
        log.append("--------------------\n");
        log.append("Created I/O Streams in listening thread \n");

        while (!client.isClosed()) {
        try {

            message = (Message)serverInputStream.readObject();
            log.append("--------------------\n");
            log.append("Got message \n" + message + "\n");

            switch (message.getOp()) {
                case CREATE: 	insert();
                    break;
                case READ: 		view();
                    break;
                case UPDATE:  	update();
                    break;
                case DELETE: 	delete();
                    break;
                case LIST:      listStaff();
                    break;
                case GETCOUNT:  getCount();
                    break;
                default:
                    break;
            }


        } catch (SQLException | NullPointerException | ClassNotFoundException ex) {
            log.append("--------------------\n");
            log.append("Exception in message processing thread " + ex + "\n");
            message.setResult(ex.getMessage());
            }
          catch ( IOException ex ) {
            log.append("--------------------\n");
            log.append("Exception in message processing thread " + ex + "\n");
            message.setResult("Closing socket. IOException " + ex.getMessage());
            try {
                client.close();
            } catch (IOException e) {
                e.printStackTrace();
            }
          }
        //send result back to client
        try {
            serverOutputStream.writeObject(message);
            log.append("--------------------\n");
            log.append("Server reply: \n" + message.toString() + "\n");
        } catch (IOException ex) {
            log.append("--------------------\n");
            log.append("writeObject failed for message: " + message.toString() + " " + ex + "\n");
            }
        }
    }//end run
}// end of class HandleAClient Runnable

    private void listStaff() {
        Statement stmtTelephone;
        ResultSet telephoneResultSet;
        int id;
        try {
            stmt = conn.createStatement();
            resultSet = stmt.executeQuery ("SELECT * from staff");

            while (resultSet.next()) {
                message.setId(resultSet.getInt(1));
                message.setLastN(resultSet.getString(2));
                message.setFirstN(resultSet.getString(3));
                message.setMi(resultSet.getString(4));
                message.setAddr(resultSet.getString(5));
                message.setCity(resultSet.getString(6));
                message.setSt(resultSet.getString(7));
                message.setMNum(resultSet.getLong(8));
                message.setHNum(resultSet.getLong(9));
                id = message.getId();
                Long mPhone = message.getMNum();
                Long hPhone = message.getHNum();
                stmtTelephone = conn.createStatement();
                telephoneResultSet = stmtTelephone.executeQuery
                    ("SELECT phonecarrier from telephone WHERE id = "+ id+" "
                        + "AND phone = " + mPhone);

                if (telephoneResultSet.next()) {
                message.setMCarrier(telephoneResultSet.getString(1));
                }

                if (hPhone > 0L) {
                stmtTelephone = conn.createStatement();
                telephoneResultSet = stmtTelephone.executeQuery
                    ("SELECT phonecarrier from telephone WHERE id = "+ id+
                        " AND phone = "+ hPhone);
                    if (telephoneResultSet.next()) {
                        message.setHCarrier(telephoneResultSet.getString(1));
                    }
                }
            try {
                serverOutputStream.writeObject(message);
                log.append("--------------------\n");
                log.append("Server list item reply: \n" + message.toString() + "\n");
                serverOutputStream.reset();
            } catch (IOException ex) {
                log.append("--------------------\n");
                log.append("writeObject failed for " + message.toString() + " " + ex + "\n");
                }
            } //end while
        } catch (SQLException e) {

        }
    } //end listStaff


	  private void view() {
        int id = message.getId();
        try {
            stmt = conn.createStatement();
            resultSet = stmt.executeQuery ("SELECT * from staff WHERE id = "+id);
            if (!resultSet.next()) {
                log.append("--------------------\n");
                log.append("Empty resultset for id= " + id + " Not Found. \n");
                message.setOp(NOTFOUND);
            } else {
                message.setLastN(resultSet.getString(2));
                message.setFirstN(resultSet.getString(3));
                message.setMi(resultSet.getString(4));
                message.setAddr(resultSet.getString(5));
                message.setCity(resultSet.getString(6));
                message.setSt(resultSet.getString(7));
                message.setMNum(resultSet.getLong(8));
                message.setHNum(resultSet.getLong(9));
                log.append("--------------------\n");
                log.append("Found Staff id = " + resultSet.getInt(1) + "\n"
                      + "lastName = " + message.getLastN() + "\n"
                      + "firstName = " + message.getFirstN() + "\n"
                      + "mi = " + message.getMi() + "\n"
                      + "address = " + message.getAddr() + "\n"
                      + "city = " + message.getCity() + "\n"
                      + "state = " + message.getSt() + "\n"
                      + "mobilephone = " + message.getMNum() + "\n"
                      + "homephone = " + message.getHNum() + "\n");
            Long mPhone = message.getMNum();
            Long hPhone = message.getHNum();
            stmt = conn.createStatement();
            resultSet = stmt.executeQuery ("SELECT phonecarrier from telephone WHERE id = "+ id+" AND phone = " + mPhone);
            if (resultSet.next()) {
                message.setMCarrier(resultSet.getString(1));
            }

            if (hPhone > 0L) {
                stmt = conn.createStatement();
                resultSet = stmt.executeQuery("SELECT phonecarrier from telephone WHERE id = "+ id+" AND phone = "+ hPhone);
                if (resultSet.next()) {
                    message.setHCarrier(resultSet.getString(1));
                }
              }
            }
          } catch (SQLException ex) {
            log.append("--------------------\n");
            log.append("resultSet from SELECT id= " + id + " Not Found. SQLExcepion " + ex + "\n");
            message.setResult(ex.getMessage());
            message.setOp(NOTFOUND);
            }
      }

	  /**Insert a new record*/
	  private void insert() throws SQLException {
          stmt = conn.createStatement();
		  preparedInsert = conn.prepareStatement("insert into  staff values (?, ?, ?, ?, ?, ?, ?, ?, ?)");
	      preparedInsert.setInt(1, message.getId());
	      preparedInsert.setString(2, message.getLastN());
	      preparedInsert.setString(3, message.getFirstN());
          preparedInsert.setString(4, message.getMi());
          preparedInsert.setString(5, message.getAddr());
          preparedInsert.setString(6, message.getCity());
          preparedInsert.setString(7, message.getSt());
          preparedInsert.setLong(8, message.getMNum());
          preparedInsert.setLong(9, message.getHNum());
	      int returnval = preparedInsert.executeUpdate();
          log.append("--------------------\n");
          log.append("Executed Staff Insert. returnval= " + returnval + "\n");

          stmt = conn.createStatement();
          preparedInsert = conn.prepareStatement("INSERT into telephone values (?, ?, ?)");
          preparedInsert.setLong(1, message.getMNum());
          preparedInsert.setString(2, message.getMCarrier());
          preparedInsert.setInt(3, message.getId());
          returnval = preparedInsert.executeUpdate();
          log.append("--------------------\n");
          log.append("Executed Mobile Telephone Insert. returnval= " + returnval + "\n");

          if (message.getHNum() > 0L) {
              stmt = conn.createStatement();
              preparedInsert = conn.prepareStatement("INSERT into telephone values (?, ?, ?)");
              preparedInsert.setLong(1, message.getHNum());
              preparedInsert.setString(2, message.getHCarrier());
              preparedInsert.setInt(3,message.getId());
              returnval = preparedInsert.executeUpdate();
              log.append("--------------------\n");
              log.append("Executed Home Telephone Insert. returnval= " + returnval + "\n");
          }
	}

	  /**Update a record*/
	  private void update() throws SQLException {
          int id = message.getId();
          stmt = conn.createStatement();
          preparedUpdate = conn.prepareStatement("UPDATE staff SET id = ?, lastName = ?, firstName = ?, mi = ?, address = ?, city = ?, state = ?, mobilephone = ?, homephone = ? WHERE id = " +id);
	      preparedUpdate.setInt(1, message.getId());
	      preparedUpdate.setString(2, message.getLastN());
	      preparedUpdate.setString(3, message.getFirstN());
          preparedUpdate.setString(4, message.getMi());
          preparedUpdate.setString(5, message.getAddr());
          preparedUpdate.setString(6, message.getCity());
          preparedUpdate.setString(7, message.getSt());
          preparedUpdate.setLong(8, message.getMNum());
          preparedUpdate.setLong(9, message.getHNum());
	      int returnval = preparedUpdate.executeUpdate();
          log.append("--------------------\n");
          log.append("Executed Update. returnval= " + returnval + "\n");

          Long phone = message.getMNum();
          stmt = conn.createStatement();
          preparedUpdate = conn.prepareStatement("UPDATE telephone SET phone = ?, phonecarrier = ? WHERE id = " + id + " AND phone = " + phone);
          preparedUpdate.setLong(1, message.getMNum());
          preparedUpdate.setString(2, message.getMCarrier());
          returnval = preparedUpdate.executeUpdate();
          log.append("--------------------\n");
          log.append("Executed Mobile Telephone update. returnval= " + returnval + "\n");

          phone = message.getHNum();
          if (phone > 0L) {
              stmt = conn.createStatement();
              preparedUpdate = conn.prepareStatement("UPDATE telephone SET phone = ?, phonecarrier = ? WHERE phone = " + phone + " AND id = " + id);
              preparedUpdate.setLong(1, message.getHNum());
              preparedUpdate.setString(2, message.getHCarrier());
              returnval = preparedUpdate.executeUpdate();
              log.append("--------------------\n");
              log.append("Executed Home Telephone update. returnval= " + returnval + "\n");
          }
	  }

	  /**Clear text fields*/
	  private void delete() throws SQLException {
          int id = message.getId();
          stmt = conn.createStatement();
          int result = stmt.executeUpdate("DELETE from telephone WHERE id = "+id);
          stmt = conn.createStatement();
          result = stmt.executeUpdate("DELETE from staff WHERE id = "+id);


	  }

      private void getCount() throws SQLException {
          stmt = conn.createStatement();
          resultSet = stmt.executeQuery("SELECT COUNT(*) FROM staff");
        if (resultSet.next()) {
          message.setCount(resultSet.getInt(1));
        }
        else
            message.setCount(-1);
      }


	public static void main(String[] args) throws IOException {
		int portNumber = 8000;

		JFrame frame = new JFrame();

		log = new JTextArea(20,50);
		log.setWrapStyleWord(true);
        log.setLineWrap(true);
		JScrollPane logPane = new JScrollPane(log,JScrollPane.VERTICAL_SCROLLBAR_AS_NEEDED,
            JScrollPane.HORIZONTAL_SCROLLBAR_NEVER);
        new SmartScroller(logPane);
		Container contentPane = frame.getContentPane();
		contentPane.add(logPane);
		frame.pack();
		frame.setVisible(true);
		StaffServer myServer = new StaffServer(portNumber);
    }
}

