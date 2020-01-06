import java.awt.Container;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.HashMap;

import javax.swing.JFrame;


public class Server {
	
	ServerGui gui;
	Socket		conn;
	ServerSocket 		serverSocket;
	ObjectInputStream serverInputStream;
	ObjectOutputStream serverOutputStream; 
	Customer customer;
	Message message;
	HashMap <Integer, Customer> customers;
	private  final int INSERT_OP = 0;
	private final int DEPOSITE_OP = 1;
	private  final int WITHDRAW_OP = 2;
	
	
	
	
	public Server(int port) throws InstantiationException, IllegalAccessException, ClassNotFoundException, IOException {
		viewGui();
		customers = new HashMap();
		startListening(port);
		
	}	
	
		
	public Boolean startListening(int listeningPort) throws IOException, InstantiationException, IllegalAccessException, ClassNotFoundException{
		
		try {
			serverSocket = new ServerSocket(listeningPort);
			gui.txtDisplayResults.append("Server Is Listening ON Port:  " + listeningPort + "\n");
			
		} catch (IOException e) {
			gui.txtDisplayResults.append(e.getMessage()+"   :It couldn't listen on the port "+listeningPort + "\n");
			return false;
		}
				
		conn = serverSocket.accept(); 
		serverInputStream = new ObjectInputStream(conn.getInputStream());
		serverOutputStream = new ObjectOutputStream(conn.getOutputStream());
		gui.txtDisplayResults.append("Connection Request ....... Connection Accepted" + "\n");
		receivingMessage();
		return true;
		
	}
	
	
	private void receivingMessage() throws IOException, ClassNotFoundException, InstantiationException, IllegalAccessException {
		
		while (true){
		
		message = null;	
		message = (Message )serverInputStream.readObject();
		customer = customers.get(message.number);
		
        switch (message.opType) { 
		
		case INSERT_OP: if (customer == null ) {
			            Customer customer = new Customer (message.number, message.name, message.balance);
						customers.put(customer.getNumber(), customer);
						gui.txtDisplayResults.append("customerNumber:  "  + customer.getNumber() +
					    "   customerName:   " + customer.getName() + "   customerBalance:   "
	                    + customer.getBalance() + " Is Inserted  " + "\n");
						} else { 
							gui.txtDisplayResults.append("customerNumber:  "  + customer.getNumber() +
						    "   customerName:   " + customer.getName() + "   customerBalance:   "
		                    + customer.getBalance() + " Is Exist  " + "\n");
						     message.number = null;
						}
				        break; 
				        
		 case DEPOSITE_OP: if (customer != null && message.amount >0) {
  	                       customer.balance += message.amount;
  	                       message.balance=customer.getBalance();
  	                       message.name = customer.getName();
  	                       gui.txtDisplayResults.append("customerNumber:  "  + customer.getNumber() +
	                       "   customerName:   " + customer.getName() + "   customerBalance:   "
                           + customer.getBalance() + "\n");
		                   } else { 
			                 gui.txtDisplayResults.append("customerNumber:  "  + message.number +
		                     "  Amount:   "  +  message.amount + " Cannot do deposit  " + "\n");
		                     message.number = null;
		                    }
                            break; 

		 case WITHDRAW_OP:  if (customer != null && message.amount > 0 && customer.balance >= message.amount) {
                             customer.balance -= message.amount;
                             message.balance=customer.getBalance();
                             message.name = customer.getName();
                             gui.txtDisplayResults.append("customerNumber:  "  + customer.getNumber() +
                             "   customerName:   " + customer.getName() + "   customerBalance:   "
                               + customer.getBalance() + "\n");
                             } else { 
                             gui.txtDisplayResults.append("customerNumber:  "  + message.number +
                             "   Amount:   "
                             + message.amount + " Cannot do withdraw  " + "\n");
                             message.number = null;
                             }
                             break; 
		 }
			
		 sendMessage(message); 
	   }
	    
		
	}

	public void sendMessage(Message message) throws IOException {
		
        serverOutputStream.writeObject(message);

	}
	
	
	void viewGui(){
	
	JFrame frame = new JFrame();
	frame.setTitle("Bank Server");
	Container contentPane = frame.getContentPane();
	gui = new ServerGui(this);
	contentPane.add(gui);
	frame.pack();
	frame.setVisible(true);
	
	}


	public void close() throws IOException{
	 serverInputStream.close();
     serverOutputStream.close();
 	 System.exit(0);
 	 
	}


	public static void main(String[] args) throws InstantiationException, IllegalAccessException, ClassNotFoundException, IOException {
	
	int 	port 	= 8000; 
	Server server = new Server(port);

	} 

}
