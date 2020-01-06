package PP4;

// CIS 611 May 5, 2019
// Programming Project PP04
// Mary Clark with Tristan Krug

import java.awt.Container;
import java.awt.Dimension;
import java.awt.Font;
import java.awt.event.ActionEvent;
import java.io.IOException;
import javax.swing.Box;
import javax.swing.BoxLayout;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.JTextArea;
import javax.swing.border.Border;
import javax.swing.border.LineBorder;
import javax.swing.border.TitledBorder;


public class UserGUI extends JPanel {


	  private JButton scrapeButton, closeButton;
      private JScrollPane scrollPane;
      private JTextArea tArea;
      private JPanel scrollPanel, btnPanel, closePanel, basePanel;
	  private Scraper scraper;
      private JLabel lblColumns;


	  private String[] url =
      { "http://www.nfl.com/players/search?category=position&filter=defensiveback&conferenceAbbr=null&playerType=current&conference=ALL",
"http://www.nfl.com/players/search?category=position&playerType=current&d-447263-p=2&conference=ALL&filter=defensiveback&conferenceAbbr=null", "http://www.nfl.com/players/search?category=position&playerType=current&d-447263-p=3&conference=ALL&filter=defensiveback&conferenceAbbr=null",
"http://www.nfl.com/players/search?category=position&playerType=current&d-447263-p=4&conference=ALL&filter=defensiveback&conferenceAbbr=null", "http://www.nfl.com/players/search?category=position&playerType=current&d-447263-p=5&conference=ALL&filter=defensiveback&conferenceAbbr=null",
"http://www.nfl.com/players/search?category=position&playerType=current&d-447263-p=6&conference=ALL&filter=defensiveback&conferenceAbbr=null", "http://www.nfl.com/players/search?category=position&playerType=current&d-447263-p=7&conference=ALL&filter=defensiveback&conferenceAbbr=null"
,"http://www.nfl.com/players/search?category=position&playerType=current&d-447263-p=8&conference=ALL&filter=defensiveback&conferenceAbbr=null", "http://www.nfl.com/players/search?category=position&playerType=current&d-447263-p=9&conference=ALL&filter=defensiveback&conferenceAbbr=null", "http://www.nfl.com/players/search?category=position&playerType=current&d-447263-p=10&conference=ALL&filter=defensiveback&conferenceAbbr=null" };

      // Constructor UserGUI
      // Initializes the GUI display
      // Initializes an actionListener for the Scrape button and close button
	  public UserGUI() throws IOException {

		  // uses the url provided in the document

	    initGUI();
	    doTheLayout();

	    scrapeButton.addActionListener( new java.awt.event.ActionListener() {
	        public void actionPerformed(ActionEvent e) {
	            scrape();
	            }
	    });

	    closeButton.addActionListener( new java.awt.event.ActionListener() {
	        public void actionPerformed(ActionEvent e){
	            close();
	            }
	    });


	  } // end of constructor


	  // Creates and initializes the GUI objects
	  private void initGUI(){
          scrapeButton = new JButton("Scrape NFL Page");
          closeButton = new JButton("Close");
          tArea = new JTextArea(20,90);
          Font font = new Font("Monospaced", Font.PLAIN, 12);
          tArea.setFont(font);
          scrollPane = new JScrollPane(tArea);
          scrollPane.setViewportView(tArea);
          Border border = LineBorder.createBlackLineBorder();
          scrollPane.setBorder(new TitledBorder(border,"Output",TitledBorder.LEFT,TitledBorder.ABOVE_TOP));
          btnPanel = new JPanel();
          btnPanel.setLayout (new BoxLayout(btnPanel, BoxLayout.LINE_AXIS));
          scrollPanel = new JPanel();
          scrollPanel.setLayout(new BoxLayout(scrollPanel, BoxLayout.PAGE_AXIS));
          lblColumns = new JLabel("Pos           Num          Player Name                              Status       TCKL          SCK          FF              INT           TEAM");
          scrollPane.setColumnHeaderView(lblColumns);
          closePanel = new JPanel();
          closePanel.setLayout(new BoxLayout(closePanel, BoxLayout.LINE_AXIS));
          basePanel = new JPanel();
          basePanel.setLayout(new BoxLayout(basePanel, BoxLayout.PAGE_AXIS));
          basePanel.add(Box.createRigidArea(new Dimension(0,5)));

	  }// end of creating objects method


	  // Layout the UI components as shown in the project document
	  private void doTheLayout() {
          btnPanel.add(scrapeButton);
          scrollPanel.add(scrollPane);
          closePanel.add(closeButton);
          basePanel.add(btnPanel);
          basePanel.add(Box.createRigidArea(new Dimension(0, 10)));
          basePanel.add(scrollPanel);
          basePanel.add(Box.createRigidArea(new Dimension(0, 10)));
          basePanel.add(closePanel);
          add(basePanel);

	  }// end of Layout method


	// Uses the Scraper object reference to return and display the data as shown in the project document
    // Instantiate a Scraper object
    // Loop through the URLs until none remain
    //   Call the scraper parseDate method
    //   Append the data from each page to JTextArea tArea for display
    // When the loop completes, close the reader and writer used by the scraper.
	 void scrape() {
        scraper = new Scraper();
        try {
         for (int i=0; i < url.length; i++) {
              scraper.parseData(url[i]);
            tArea.append(scraper.display().toString());
         }
         scraper.getReader().close();
         scraper.getWriter().close();
        } catch (IOException eio) {
            System.out.println("IO Exception " + eio);
        }
	  }// end of scrape action event method


	  void close(){
	      System.exit(0);
	  }// end of close action event method

	public static void main(String[] args) throws IOException {
	   JFrame f = new JFrame("NFL Stats");
        f.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        Container contentPane = f.getContentPane();
        contentPane.add( new UserGUI());
        f.pack();
        f.setVisible(true);
	}// end of main method

}// end of class
