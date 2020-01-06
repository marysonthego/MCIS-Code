
//*********************************************************************
//*                                                                   *
//*   CIS611                Spring, 2019    Tristan Krug & Mary Clark *
//*                                                                   *
//*                    Programming Project PP1                        *
//*                                                                   *
//*                         Description                               *
//*  Class Name: Direction                                            *
//*                                                                   *
//*  The purpose of the Direction class is to solve a maze based on a *
//*  set of provided Movement Rules. All logic for movement is        *
//*  contained in the run() method. The Movement Rules are:           *
//*  1. The student icon is always in the row and column zero         *
//*  2. The Java logo can be anywhere in the maze                     *
//*  3. Maze contains moving obstacles shown as "Wrong Way" signs     *
//*  4. The first row and column is index 0, the second row and column* 
//*     is index 1, and so on. The number zero is even number         *
//*  5. Following the steps below, you should move student icon from  *
//*     left to right                                                 *
//*  6. On even columns, you must move up to down, on odd columns,    *
//*     you must move down to up                                      *
//*  7. Call maze.isDone() for every move to see if you have found    *
//*     the Java logo                                                 *
//*  8. After completing each column (either moving to the top or     *
//*     down), use move up/down method to proceed to the next row,    *
//*     stop when you reach the last cell (with index of row 0 and    *
//*     number of column-1) or find the Java logo                     *
//*  9. You should check the column and row boundaries to start moving* 
//*     in the reverse direction when boundaries are reached          *
//* 10. You should check the return value from move methods for every *
//*     call, true means no obstacle, false means obstacle            *
//*     (cannot move).                                                *
//* 11. At row 0 or the last row, where you cannot move up or down    *
//*     any further, respectively, move right in order to either      *
//*     move down in even rows or up in odd rows                      *
//* 12. If you encounter an obstacle when moving down on even columns:*
//*         o Move right, down, down, and then left                   *
//*         o Adjust the control loops for the extra moves!           *
//* 13. If you encounter an obstacle when moving up on odd columns:   *
//*         o Move left, up, up, and then right.                      *
//*         o Adjust the control loop for the extra moves!            *
//* 14. When the Java logo is found, you must immediately break       *
//*     out of all loops, and show an appropriate message in the      *
//*     text area indicating Java Logo is found.                      *
//*********************************************************************


public class Direction extends Thread {

	Maze maze;
	Position location;

	Direction(Maze maze, Position location) {

		this.maze = maze;
		this.location = location;
	}

	public void run() {

	    char lastMove = 'S';
	    // S = Start
	    // F = Finish
	    // D = Down  d = not down
	    // U = Up    u = not up
	    // L = Left  l = not left
	    // R = Right r = not right
	    // X = Couldn't move
	    
		while (lastMove != 'F') {
		    switch (lastMove) {
		    case 'S':
		        lastMove = tryDown();
		        break;
		    case 'D':
		        lastMove = tryDown();
		        break;
		    case 'd':
		        if ((lastMove = tryLeft()) == 'l')
		            lastMove = tryRight();
		        break;
		    case 'R':
		        lastMove = tryRight();
		        break;
		    case 'r':
		        if ((lastMove = tryDown()) == 'd')
		           lastMove = tryUp();
		        break;
		    case 'U':
		        lastMove = tryUp();
		        break;
		    case 'u':
		        if ((lastMove = tryLeft()) == 'l')
		            lastMove = tryRight();
		        break;
		    case 'L':
		        lastMove = tryLeft();
		        break;
		    case 'l':
		        if ((lastMove = tryUp()) == 'u')
		                lastMove = tryDown();
		        break;
		    case 'F':
		        break;
		    }
		}
        location.textArea.append("FOUND JAVA" + "\n");
	}

    public char tryDown() {
				if (this.maze.moveDown()) {
				    location.textArea.append("Success Down" + "\n");
				    location.textArea.append("Moved to row " + maze.getCurrRow() + ", column " + maze.getCurrCol() + "\n");
				    if (maze.isDone())
				        return 'F';
				    else return 'D';
				} else return 'd';
    }
    
    public char tryUp() {
        if (this.maze.moveUp()) {
            location.textArea.append("Success Up" + "\n");
            location.textArea.append("Moved to row " + maze.getCurrRow() + ", column " + maze.getCurrCol() + "\n");
            if (maze.isDone())
                return 'F';
            else return 'U';
        } else return 'u';
}				
    
    public char tryLeft() {
        if (this.maze.moveLeft()) {
            location.textArea.append("Success Left" + "\n");
            location.textArea.append("Moved to row " + maze.getCurrRow() + ", column " + maze.getCurrCol() + "\n");
            if (maze.isDone())
                return 'F';
            else return 'L';
        } else return 'l';
}               
    
    public char tryRight() {
        if (this.maze.moveRight()) {
            location.textArea.append("Success Right" + "\n");
            location.textArea.append("Moved to row " + maze.getCurrRow() + ", column " + maze.getCurrCol() + "\n");
            if (maze.isDone())
                return 'F';
            else return 'R';
        } else return 'r';
}               

	public void printCurrLoc() {
		// function to print the current student location to textArea
		location.textArea.append("Moved to row " + maze.getCurrRow() +", column " + maze.getCurrCol() + "\n");
	}
}
