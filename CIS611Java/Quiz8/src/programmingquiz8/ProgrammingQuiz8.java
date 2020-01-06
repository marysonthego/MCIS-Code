package programmingquiz8;

import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.border.Border;
import javax.swing.border.LineBorder;
import javax.swing.border.TitledBorder;


	public class ProgrammingQuiz8 extends JFrame implements ActionListener {
	public ProgrammingQuiz8() {
        Border border = new TitledBorder("My Button");
	JButton jbtOK = new JButton ("OK");
         jbtOK.setBorder(border);
	JButton jbtCancel = new JButton("Cancel");
    jbtCancel.setBorder(new LineBorder(Color.yellow));
	getContentPane().add(jbtOK);
	getContentPane().add(jbtCancel);
	jbtOK.addActionListener(this);
        jbtCancel.addActionListener(this);
        add (jbtOK, BorderLayout.NORTH);
        add(jbtCancel, BorderLayout.SOUTH);
    }
        public void actionPerformed(ActionEvent e) {
            System.out.println("A button is clicked");
    }

	public static void main(String[] args) {
            JFrame frame = new ProgrammingQuiz8();
            frame.setSize(300, 300);
            frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
            frame.setVisible(true);
    }
}

