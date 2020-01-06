package PP4;

import java.awt.BorderLayout;
import java.awt.Container;
import java.awt.Dimension;
import java.awt.FlowLayout;
import java.awt.ScrollPane;
import java.awt.event.ActionEvent;
import java.io.BufferedWriter;
import java.io.FileWriter;
import java.io.IOException;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JTextArea;

@SuppressWarnings("serial")
public class UserGUI extends JPanel {

	private JButton scrapeButton;
	private JButton closeButton;
	// add more UI components as needed
	private Scraper scraper;
	private JTextArea display;
	private ScrollPane scrollPane;
	private final String url = "http://www.nfl.com/players/search?category=position&filter=defensiveback&conferenceAbbr=null&playerType=current&conference=ALL",
			header = "Pos	Num	Player Name                   	Status	TCKL	SCK	INT	Team" + System.lineSeparator();
	private JPanel controlPane, textPane, mainPane;

	public UserGUI() {

		// uses the url provided in the document
		initGUI();
		doTheLayout();
		this.display.setText(header);

		scrapeButton.addActionListener(new java.awt.event.ActionListener() {
			public void actionPerformed(ActionEvent e) {
				scrape();
			}
		});

		closeButton.addActionListener(new java.awt.event.ActionListener() {
			public void actionPerformed(ActionEvent e) {
				close();
			}
		});

	} // end of constructor

	// Creates and initialize the GUI objects
	private void initGUI() {
		scrapeButton = new JButton("Scrape");
		closeButton = new JButton("Close");
		display = new JTextArea(5, 20);
		scrollPane = new ScrollPane();
		scrollPane.setPreferredSize(new Dimension(840, 420));
		controlPane = new JPanel(new FlowLayout(FlowLayout.RIGHT));
		textPane = new JPanel(new FlowLayout());
		mainPane = new JPanel(new BorderLayout());

	}// end of creating objects method

	// Layouts the UI components as shown in the project document
	private void doTheLayout() {
		controlPane.add(scrapeButton);
		controlPane.add(closeButton);
		scrollPane.add(display);
		textPane.add(scrollPane);
		mainPane.add(textPane, "Center");
		mainPane.add(controlPane, "South");
		this.add(mainPane);
	}// end of Layout method

	// Uses the Scraper object reference to return and display the data as shown in
	// the project document
	void scrape() {
		// Create scraper object
		this.scraper = new Scraper(url);
		scraper.parseData();
		
		// get results from scraper object
		String results = scraper.display();
		
		// send results to the text area
		this.display.append(results);
		
		// write results to file 
		try {
			writeToFile("NFLStat.txt",header + results);
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}

	}// end of scrape action event method

	void close() {
		System.exit(0);
	}// end of close action event method

	public void writeToFile(String fileName, String results) throws IOException {
		// write results to file

		BufferedWriter buff = new BufferedWriter(new FileWriter(fileName));
		buff.write(results);
		buff.close();
	}

	public static void main(String[] args) {
		JFrame f = new JFrame("NFL Stats");
		f.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		f.setResizable(false);
		Container contentPane = f.getContentPane();
		contentPane.add(new UserGUI());
		f.pack();
		f.setVisible(true);
	}// end of main method

}// end of class
