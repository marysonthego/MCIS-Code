// This class must have the code in the run() method, sub-program/routain to slove the maze;
//   seraches for the Java logo based on the provided path/direction algorithm

public class Direction extends Thread{

	Maze maze;
	Position location;
	char lastMove;
	
	Direction(Maze maze, Position location) {
		
		this.maze = maze;
		this.location = location;
		lastMove = 'D';
	}
	
	// this is the code part that needs to be programmed by students to solve the maze 
	// using the provided path/direction algorithm
	public void run(){

		// this is a SAMPLE code of moving the student image in the maze,
		// and updates the information in Position.jav GUI class, append text into the JTextArea object
		// you should delete this code and start your solution, you may just keep the part of updating the information
		// in the Position.java class, appending information into the JTextArea object
				
		while(!this.maze.isDone()) {
		System.out.println("lastMove = " + lastMove);	
		
			if (lastMove == 'D') { //down
				if (this.maze.moveRight())
					lastMove = 'R';
				else if (this.maze.moveLeft())
					lastMove = 'L';
				else if (this.maze.moveDown())
					lastMove = 'D';
				else if (this.maze.moveUp())
					lastMove = 'U';
				continue;
			} 
			if (lastMove == 'L') {  //left
				if (this.maze.moveDown())
					lastMove = 'D';
				else if (this.maze.moveUp())
					lastMove = 'U';
				else if (this.maze.moveLeft())
					lastMove = 'L';
				else if (this.maze.moveRight())
					lastMove = 'R';
				continue;
			} 
			if (lastMove == 'U') {  //up
				if (this.maze.moveRight())
					lastMove = 'R';
				else if (this.maze.moveLeft())
					lastMove = 'L';
				else if (this.maze.moveUp())
					lastMove = 'U';
				else if (this.maze.moveDown())
					lastMove = 'D';
				continue;
			}
			if (lastMove == 'R') {  //right
				if (this.maze.moveUp())
					lastMove = 'U';
				else if (this.maze.moveDown())
					lastMove = 'D';
				else if (this.maze.moveRight())
					lastMove = 'R';
				else if (this.maze.moveLeft())
					lastMove = 'L';
				continue;
			}
		}
		System.out.println("Logo Found \n");
				
		}	
		
	}