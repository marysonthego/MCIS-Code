package PP03;

    // 1- add the class constructor
    // 2- add the setters/getters methods
    // 3- add override method toString()



import java.time.LocalDate;
import java.time.format.DateTimeFormatter;


public class PayPeriod {

	private int pID;
    private LocalDate pStartDate, pEndDate;
    private DateTimeFormatter formatter = DateTimeFormatter.ofPattern("M'/'d'/'yyyy");

    public PayPeriod(int id, LocalDate start, LocalDate end) {
        pID = id;
        pStartDate = start;
        pEndDate = end;
    }

    public int getPayID() {
        return pID;
    }

    public LocalDate getStartDate() {
        return pStartDate;
    }

    public LocalDate getEndDate() {
        return pEndDate;
    }

    public void setPayID(int id) {
        pID = id;
    }

    public void setStartDate(LocalDate start) {
        pStartDate = start;
    }

    public void setEndDate(LocalDate end){
        pEndDate = end;
    }

    @Override
    public String toString() {
    	return "PayPeriod [pID=" + pID + ", StartDate=" + pStartDate.format(formatter) + ", EndDate=" + pEndDate.format(formatter) + "]";
    }
}
