// This class must have the code in the run() method, sub-program/routain to slove the maze;
//   seraches for the Java logo based on the provided path/direction algorithm

public class Direction extends Thread { 

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
		
	/*
	 * Movement’s Rules
    1. The student icon is always in the row and column zero
    2. The Java logo can be anywhere in the maze
    3. Maze contains moving obstacles shown as "Wrong Way" signs
    4. The first row and column is index 0, the second row and column is index 1, and so on.
    The number zero is even number
    5. Following the steps below, you should move student icon from left to right
    6. On even columns, you must move up to down, on odd columns, you must move down to
    up
    7. Call maze.isDone() for every move to see if you have found the Java logo8. After completing 
    each column (either moving to the top or down), use move up/down
    method to proceed to the next row, stop when you reach the last cell (with index of row 0
    and number of column-1) or find the Java logo
    9. You should check the column and row boundaries to start moving in the reverse direction
    when boundaries are reached
    10. You should check the return value from move methods for every call, true means no
    obstacle, false means obstacle (cannot move).
    11. At row 0 or the last row, where you cannot move up or down any further, respectively,
    move right in order to either move down in even rows or up in odd rows
    12. If you encounter an obstacle when moving down on even columns:
    o Move right, down, down, and then left
    o Adjust the control loops for the extra moves!
    13. If you encounter an obstacle when moving up on odd columns:
    o Move left, up, up, and then right.
    o Adjust the control loop for the extra moves!
    14. When the Java logo is found, you must immediately break out of all loops, and show an
    appropriate message in the text area indicating Java Logo is found
    You should test your code with the provided 2 mazes files. In addition to checking visually, you
    should show in the text area the row and column of the student, and you can use that to debug
    your code.
    */
	    int currCol = maze.getCurrCol();
	    int currRow = maze.getCurrRow();
	    int height = maze.getHeight() -1;
	    int width = maze.getWidth() -1;
	    
	    // 6. On even columns, you must move up to down, on odd columns, you must move down to up
	    if (currCol %2 == 0) { //even column
	        if (currRow < height) {  // check row boundary - not at the bottom row
	            // check the return value from move methods for every call
	            // check the column and row boundaries to start moving in the reverse direction
	            // when boundaries are reached
	            if (maze.moveDown()) { // can move down
	                currCol = maze.getCurrCol();
	                currRow = maze.getCurrRow();
	                if (maze.isDone()) { // found logo
	                    location.textArea.append("Logo Found at Row: " + currRow + " Col: " + currCol + "\n");
	                    break;
	                } // end found logo
	            } // end can move down
	            else { // can't move down - obstacle
	                // 12. If you encounter an obstacle when moving down on even columns: 
	                // Move right, down, down, and then left
	                if (maze.moveRight()) { // can move right
	                    currCol = maze.getCurrCol();
	                    currRow = maze.getCurrRow();
	                    if (maze.isDone()) { // found logo
	                        location.textArea.append("Logo Found at Row: " + currRow + " Col: " + currCol + "\n");
	                        break;
	                    } // end found logo
	                } // end can move right
	                else { // can't move right
	                    if (maze.moveUp()) { // can move up
	                        currCol = maze.getCurrCol();
	                        currRow = maze.getCurrRow();
	                        if (maze.isDone()) { // found logo
	                            location.textArea.append("Logo Found at Row: " + currRow + " Col: " + currCol + "\n");
	                        } // end found logo
	                    } // end can move up (since this is where we came from, we should always be able to move up)
                    } // end can't move right
	                if (maze.moveRight()) { // try again to move right
                            currCol = maze.getCurrCol();
                            currRow = maze.getCurrRow();
                            if (maze.isDone()) { // found logo
                                location.textArea.append("Logo Found at Row: " + currRow + " Col: " + currCol + "\n");
                            } // end found logo
	                } // end try again to move right
	                else { // still can't move right 
                        if (maze.moveUp()) { // can move up
                            currCol = maze.getCurrCol();
                            currRow = maze.getCurrRow();
                            if (maze.isDone()) { // found logo
                                location.textArea.append("Logo Found at Row: " + currRow + " Col: " + currCol + "\n");
                            } // end found logo
                        } // end can move up 
	                }
	                maze.moveDown();
	                maze.moveDown();
	                maze.moveLeft();
	                
	            } // end can't move down - obstacle
	        } // end if not at the bottom row
	        
	            
	    } // end if even column
	    
		// Mary Clark PP1 Part 1 2/21/2019
		/* Remove (comment) all code from Part I that moves the student icon in the maze.
		 *		
		while (!this.maze.isDone()) {
			//System.out.println("lastMove = " + lastMove);
			if (lastMove == 'D') { //down
				if (this.maze.moveDown()) {
				    lastMove = 'D';
				    location.textArea.append("Success" + "\n");
				    location.textArea.append("Moved to row " + maze.getCurrRow() + ", column " + maze.getCurrCol() + "\n");
				    if (maze.isDone())
				        break;
				} else { //can't move down
				    location.textArea.append("Failure" + "\n");
				    location.textArea.append("Moved to row " + maze.getCurrRow() + ", column " + maze.getCurrCol() + "\n");
				    if (this.maze.moveRight()) {
				        lastMove = 'R';
				        location.textArea.append("Success" + "\n");
				        location.textArea.append("Moved to row " + maze.getCurrRow() + ", column " + maze.getCurrCol() + "\n");
				        if (maze.isDone())
				            break;
				        } else { //can't move right
				            location.textArea.append("Failure" + "\n");
				            location.textArea.append("Moved to row " + maze.getCurrRow() + ", column " + maze.getCurrCol() + "\n");
				            if (this.maze.moveLeft()) {
				                lastMove = 'L';
				                location.textArea.append("Success" + "\n");
				                location.textArea.append("Moved to row " + maze.getCurrRow() + ", column " + maze.getCurrCol() + "\n");
				                if (maze.isDone())
				                    break;
				            } else { //can't move left
				                location.textArea.append("Failure" + "\n");
				                location.textArea.append("Moved to row " + maze.getCurrRow() + ", column " + maze.getCurrCol() + "\n");
				                if (this.maze.moveUp()) {
				                    lastMove = 'U';
				                    location.textArea.append("Success" + "\n");
				                    location.textArea.append("Moved to row " + maze.getCurrRow() + ", column " + maze.getCurrCol() + "\n");
				                    if (maze.isDone())
				                        break;
				                } else // can't move up
				                    location.textArea.append("Failure" + "\n");
				                    location.textArea.append("Moved to row " + maze.getCurrRow() + ", column " + maze.getCurrCol() + "\n");
				            } // end can't move left
				        } // end can't move right
				    } // end can't move down
			    } // end if last move was down
			
			else { if (lastMove == 'L') {  //left
				if (this.maze.moveLeft()) {
				    lastMove = 'L';
				    location.textArea.append("Success" + "\n");
				    location.textArea.append("Moved to row " + maze.getCurrRow() + ", column " + maze.getCurrCol() + "\n");
                    if (maze.isDone())
                        break;
				} else { // can't move left
                    location.textArea.append("Failure" + "\n");
                    location.textArea.append("Moved to row " + maze.getCurrRow() + ", column " + maze.getCurrCol() + "\n");
                    if (this.maze.moveDown()) {
                        lastMove = 'D';
                        location.textArea.append("Success" + "\n");
                        location.textArea.append("Moved to row " + maze.getCurrRow() + ", column " + maze.getCurrCol() + "\n");
                        if (maze.isDone())
                            break;
                    } else {
                        location.textArea.append("Failure" + "\n");
                        location.textArea.append("Moved to row " + maze.getCurrRow() + ", column " + maze.getCurrCol() + "\n");
                        if (this.maze.moveUp()) {
                            lastMove = 'U';
                            location.textArea.append("Success" + "\n");
                            location.textArea.append("Moved to row " + maze.getCurrRow() + ", column " + maze.getCurrCol() + "\n");
                            if (maze.isDone())
                                break;
                        } else {
                            location.textArea.append("Failure" + "\n");
                            location.textArea.append("Moved to row " + maze.getCurrRow() + ", column " + maze.getCurrCol() + "\n");
                            if (this.maze.moveRight()) {
                                lastMove = 'R';
                                location.textArea.append("Success" + "\n");
                                location.textArea.append("Moved to row " + maze.getCurrRow() + ", column " + maze.getCurrCol() + "\n");
                                if (maze.isDone())
                                    break;
                            } else
                                location.textArea.append("Failure" + "\n");
                                location.textArea.append("Moved to row " + maze.getCurrRow() + ", column " + maze.getCurrCol() + "\n");
                        }  // end can't move up
                    } // end can't move down
				} // end can't move left
			} // end if last move was left
			
			else { if (lastMove == 'U') {  //up
				if (this.maze.moveUp()) {
                    lastMove = 'U';
                    location.textArea.append("Success" + "\n");
                    location.textArea.append("Moved to row " + maze.getCurrRow() + ", column " + maze.getCurrCol() + "\n");
                    if (maze.isDone())
                        break;
                } else { // can't move up
                    location.textArea.append("Failure" + "\n");
                    location.textArea.append("Moved to row " + maze.getCurrRow() + ", column " + maze.getCurrCol() + "\n");
                    if (this.maze.moveLeft()) {
                        lastMove = 'L';
                        location.textArea.append("Success" + "\n");
                        location.textArea.append("Moved to row " + maze.getCurrRow() + ", column " + maze.getCurrCol() + "\n");
                        if (maze.isDone())
                            break;
                    } else { // can't move left
                        location.textArea.append("Failure" + "\n");
                        location.textArea.append("Moved to row " + maze.getCurrRow() + ", column " + maze.getCurrCol() + "\n");
                        if (this.maze.moveRight()) {
                            lastMove = 'R';
                            location.textArea.append("Success" + "\n");
                            location.textArea.append("Moved to row " + maze.getCurrRow() + ", column " + maze.getCurrCol() + "\n");
                            if (maze.isDone())
                                break;
                        } else { // can't move right
                            location.textArea.append("Failure" + "\n");
                            location.textArea.append("Moved to row " + maze.getCurrRow() + ", column " + maze.getCurrCol() + "\n");
                            if (this.maze.moveDown()) {
                                lastMove = 'D';
                                location.textArea.append("Success" + "\n");
                                location.textArea.append("Moved to row " + maze.getCurrRow() + ", column " + maze.getCurrCol() + "\n");
                                if (maze.isDone())
                                    break;
                            } else
                                location.textArea.append("Failure" + "\n");
                                location.textArea.append("Moved to row " + maze.getCurrRow() + ", column " + maze.getCurrCol() + "\n");
                        } // end can't move right
                    } // end can't move left
                } // end can't move up
			} // end if last move was up
			
			else { if (lastMove == 'R') {  //right
				    if (this.maze.moveRight()) {
				        lastMove = 'R';
				        location.textArea.append("Success" + "\n");
				        location.textArea.append("Moved to row " + maze.getCurrRow() + ", column " + maze.getCurrCol() + "\n");
				        if (maze.isDone())
				            break;
				    } else { // can't move right
				        location.textArea.append("Failure" + "\n");
				        location.textArea.append("Moved to row " + maze.getCurrRow() + ", column " + maze.getCurrCol() + "\n");
				        if (this.maze.moveDown()) {
				            lastMove = 'D';
				            location.textArea.append("Success" + "\n");
				            location.textArea.append("Moved to row " + maze.getCurrRow() + ", column " + maze.getCurrCol() + "\n");
				            if (maze.isDone())
				                break;
				        } else { // can't move down
				            location.textArea.append("Failure" + "\n");
				            location.textArea.append("Moved to row " + maze.getCurrRow() + ", column " + maze.getCurrCol() + "\n");
				            if (this.maze.moveUp()) {
				                lastMove = 'U';
				                location.textArea.append("Success" + "\n");
				                location.textArea.append("Moved to row " + maze.getCurrRow() + ", column " + maze.getCurrCol() + "\n");
				                if (maze.isDone())
				                    break;
				            } else { // can't move up
				                location.textArea.append("Failure" + "\n");
				                location.textArea.append("Moved to row " + maze.getCurrRow() + ", column " + maze.getCurrCol() + "\n");
				                if (this.maze.moveLeft()) {
				                    lastMove = 'L';
				                    location.textArea.append("Success" + "\n");
				                    location.textArea.append("Moved to row " + maze.getCurrRow() + ", column " + maze.getCurrCol() + "\n");
				                    if (maze.isDone())
				                        break;
				                } else
				                    location.textArea.append("Failure" + "\n");
				                    location.textArea.append("Moved to row " + maze.getCurrRow() + ", column " + maze.getCurrCol() + "\n");
				                } // end can't move up
				            } // end can't move down
				        } // end can't move right
			        } // end if last move was right
			    } // end else if last move was right
			} // end else if last move was up
		} // end else if last move was left			
	} // end while			
		location.textArea.append("Logo Found \n");
		location.textArea.append("Moved to row " + maze.getCurrRow() + ", column " + maze.getCurrCol() + "\n");
	*/	
  } // end run()	
} // end class