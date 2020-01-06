// This class must have the code in the run() method, sub-program/routain to slove the maze;
//   seraches for the Java logo based on the provided path/direction algorithm

public class Direction extends Thread {

	Maze maze;
	Position location;

	Direction(Maze maze, Position location) {

		this.maze = maze;
		this.location = location;
	}

	public void run() {

		String vDir = "down"; 				// The current vertical direction of the player
		String hDir = "right"; 				// The current horizontal direction of the player
		int vMin = 0, hMin = 0;
		int vMax = maze.getHeight() - 1;	// The "top" of the current column where the player will turn around once hit
		int hMax = maze.getWidth() - 1; 	// The far right side of the maze where the player will turn around
		int iBlock = -1; 					// The obstacle resolution state. -1 is deactivated (no current obstacle)
		int hBlock = 0;
		boolean fromThere = false;
		int prevCol = 0;

		// Movement block - should only exit when the maze is complete OR at the end of the maze
		while (!maze.isDone()) {

			// Advancing block - Moves the student forward until a boundary OR obstacle is hit.
			// Check if at max, try to move forward. If successfully moves forward then repeat.
			// If blocked then initiate obstacle block. If at max then move on to turning block.
			//while ((vDir == "down" && maze.getCurrRow() != vMax) || (vDir == "up" && (maze.getCurrRow() != vMin && !fromThere)) && !maze.isDone()) {
		    //while ((vDir == "down" && maze.getCurrRow() != vMax) && !maze.isDone()) {
		    while (maze.getCurrRow() != vMax && !maze.isDone()) {
				// First check if you're at the max column position
				// if not then head in vDir direction
				if (vDir == "down") { 		// try to move down
					if (!maze.moveDown() && !fromThere) { // if an obstacle is is the way
	                   while (!maze.moveRight()) {     // navigate around obstacle
	                        if (!maze.moveUp())
	                            maze.moveLeft();
	                            fromThere = true;
	                            this.printCurrLoc();
	                   } 
                       iBlock = 2;
                       hBlock++;   // set obstacle condition
					} 
				} else { 					// try to move Up
					if (!maze.moveUp()&& !fromThere) { 	// if an obstacle is is the way
					    while (!maze.moveLeft()) {   // navigate around obstacle
                            if (!maze.moveDown())
                                maze.moveRight();
                                fromThere = true;
                                this.printCurrLoc();
                        } 	// navigate around obstacle
						iBlock = 2; 		// set obstacle modifier
                        hBlock++;
					}
				}
				this.printCurrLoc();
				
				// Obstacle block - If an obstacle has been set then this block resolves it
				if (iBlock > 0) { 	// move forward if the obstacle is 1 or 2 (to move 2 spaces)
					iBlock--; 		// decrement obstacle if larger than zero
				} else if (iBlock == 0 && !maze.isDone()) { // when the obstacle count decrements to zero initiate a turn
				    while (hBlock > 0) {
				        if (vDir == "down") {
				            maze.moveLeft(); 	// Turn in the correct direction depending on your current vDir
				        } else {
				            maze.moveRight(); 	// Turn in the correct direction depending on your current vDir
				        }
				        hBlock--;
				    }
					iBlock = -1; 			// turn off the block state once it has been resolved
					//fromThere = false;
					this.printCurrLoc();
				}
			}

			//break out of the loop if the student has navigated to the final square
			if (maze.getCurrRow() == vMax && maze.getCurrCol() == hMax) break;

			// Turning block - Only accessed when the student has hit a boundary
			
			if (!maze.isDone()) {
				// Turn in the direction as established by hDir
				if (hDir == "right" && maze.getCurrCol() == prevCol) {
					maze.moveRight();
					//prevCol = maze.getCurrCol();
					fromThere = false;
				} else {
					maze.moveUp();
					fromThere = true;
					vDir = "up";
				}
				// reassign vDir and vMax for the new column & vertical direction
				if (maze.getCurrCol() % 2 == 0) { // current location is EVEN - go DOWN
					vDir = "down";
					//vMax = maze.getHeight() - 1;
				} else { // current location is ODD - go UP
					vDir = "up";
					//vMax = 0;
				}
				this.printCurrLoc();
			}
		}
		
		// Print the final status of the maze
		if (maze.isDone()) {
			location.textArea.append("Logo Found \n");
		} else {
			location.textArea.append("Logo could not be found \n");
		}
	}

	public void printCurrLoc() {
		// function to print the current student location to textArea
		location.textArea.append("Moved to row " + maze.getCurrRow() +", column " + maze.getCurrCol() + "\n");
	}
}
