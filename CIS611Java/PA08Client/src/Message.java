import java.io.Serializable;

public class Message implements Serializable {

	private int id, op;
	private String lastN, firstN;
	private String mi;
	private String addr, city, st;
	private int count;
    private long mNum, hNum;
	private String mCarrier, hCarrier;
    private String result;

	//constructor for create, update
	public Message(int op, int id, String lastN, String firstN,
			String mi, String addr, String city, String st,
			long mNum, long hNum, String mCarrier, String hCarrier) {

		this.op = op;
		this.id = id;
		this.lastN = lastN;
		this.firstN = firstN;
		this.mi = mi;
		this.addr = addr;
		this.city = city;
		this.st = st;
		this.mNum = mNum;
		this.hNum = hNum;
		this.mCarrier = mCarrier;
		this.hCarrier = hCarrier;
	}

	//constructor for read, delete, count
	public Message(int op, int id) {
		this.op = op;
		this.id = id;
	}

    @Override
    public String toString() {
        return "Message: op = " + op + "\nid = " + id + "\nlastN = " + lastN + "\nfirstN = " + firstN + " mi = " + mi + "\naddr = " + addr + "\n city = " + city + " st = " + st + "\nmNum = " + mNum + " hNum = " + hNum + "\nmCarrier = " + mCarrier + " hCarrier = " + hCarrier + "\ncount = " + count + "\nResult = " + result;
    }

	//default constructor
	public Message() {

	}

	public int getOp() {
		return op;
	}
	public int getId() {
		return id;
	}
	public String getLastN() {
		return lastN;
	}
	public String getFirstN() {
		return firstN;
	}
	public String getMi() {
		return mi;
	}
	public String getAddr() {
		return addr;
	}
	public String getCity() {
		return city;
	}
	public String getSt() {
		return st;
	}
	public long getMNum() {
		return mNum;
	}
	public long getHNum() {
		return hNum;
	}
	public String getMCarrier() {
		return mCarrier;
	}
	public String getHCarrier() {
		return hCarrier;
	}
    public int getCount() {
        return count;
    }
    public String getResult() {
        return result;
    }
	public void setOp(int op) {
		this.op = op;
	}
	public void setId(int id) {
		this.id = id;
	}
	public void setLastN(String lastN) {
		this.lastN = lastN;
	}
	public void setFirstN(String firstN) {
		this.firstN = firstN;
	}
	public void setMi(String mi) {
		this.mi = mi;
	}
	public void setAddr(String addr) {
		this.addr = addr;
	}
	public void setCity(String city) {
		this.city = city;
	}
	public void setSt(String st) {
		this.st = st;
	}
	public void setMNum(long mNum) {
		this.mNum = mNum;
	}
	public void setHNum(long hNum) {
		this.hNum = hNum;
	}
	public void setMCarrier(String mCarrier) {
		this.mCarrier = mCarrier;
	}
	public void setHCarrier(String hCarrier) {
		this.hCarrier = hCarrier;
	}
    public void setCount(int count) {
        this.count = count;
    }
    public void setResult(String result) {
        this.result = result;
    }
}
