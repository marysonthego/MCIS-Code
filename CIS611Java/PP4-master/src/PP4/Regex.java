package PP4;

import java.util.regex.Pattern;

public class Regex {

	// pattern attributes
	private Pattern pos;
	private Pattern num;
	private Pattern playerName;
	private Pattern status;
	private Pattern tckl;
	private Pattern sck;
	private Pattern intt;
	private Pattern team;

	// constructor
	public Regex(Pattern pos, Pattern num, Pattern playerName, Pattern status, Pattern tckl, Pattern sck, Pattern intt,
			Pattern team) {
		this.setPos(pos);
		this.setNum(num);
		this.setPlayerName(playerName);
		this.setStatus(status);
		this.setTckl(tckl);
		this.setSck(sck);
		this.setIntt(intt);
		this.setTeam(team);
	}

	// add getter and setter methods
	
	public Pattern getPos() {
		return pos;
	}

	public void setPos(Pattern pos) {
		this.pos = pos;
	}

	public Pattern getNum() {
		return num;
	}

	public void setNum(Pattern num) {
		this.num = num;
	}

	public Pattern getPlayerName() {
		return playerName;
	}

	public void setPlayerName(Pattern playerName) {
		this.playerName = playerName;
	}

	public Pattern getStatus() {
		return status;
	}

	public void setStatus(Pattern status) {
		this.status = status;
	}

	public Pattern getTckl() {
		return tckl;
	}

	public void setTckl(Pattern tckl) {
		this.tckl = tckl;
	}

	public Pattern getSck() {
		return sck;
	}

	public void setSck(Pattern sck) {
		this.sck = sck;
	}

	public Pattern getIntt() {
		return intt;
	}

	public void setIntt(Pattern intt) {
		this.intt = intt;
	}

	public Pattern getTeam() {
		return team;
	}

	public void setTeam(Pattern team) {
		this.team = team;
	}
	
}
