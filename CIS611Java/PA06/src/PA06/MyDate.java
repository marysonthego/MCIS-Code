package PA06; 

//import java.util.Calendar;
import java.time.LocalDateTime;
import java.time.ZoneOffset;

/*
 * A MyDate class needs to be coded with a java.util.date attribute, which is the
 * hire date. MyDate will have myDate attribute with public getter and setter. 
 */

class MyDate {
  private int year;
  private int month;
  private int day;
  
  private LocalDateTime localDT;
  
  MyDate() {    
    localDT = LocalDateTime.now();
    year = localDT.getYear();
    month = localDT.getMonthValue();
    day = localDT.getDayOfMonth();
    //GregorianCalendar date = new GregorianCalendar();
    // Find year, month, and day from date. You write your own code to replace the out-dated get methods
    //year = date.get(Calendar.YEAR);
    //month = date.get(Calendar.MONTH);
    //day = date.get(Calendar.DAY_OF_MONTH);
    
 
  }
  
  MyDate(long elapsedTime) {   
    localDT =  LocalDateTime.ofEpochSecond(elapsedTime, 0, ZoneOffset.of("-07:00"));
    year = localDT.getYear();
    month = localDT.getMonthValue();
    day = localDT.getDayOfMonth();
    
    //GregorianCalendar date = new GregorianCalendar();
    //date.setTimeInMillis(elapsedTime);
    // Find year, month, and day from date. You write your own code to replace the out-dated get methods
    //year = date.get(Calendar.YEAR);
    //month = date.get(Calendar.MONTH);
    //day = date.get(Calendar.DAY_OF_MONTH);
  }
    
  MyDate(int year, int month, int day) {
    this.year = year;
    this.month = month;
    this.day = day;
    localDT = LocalDateTime.of(year, month, day, 0, 0);
  }
  
  public int getYear() {
    return year;
  }

  public int getMonth() {
    return month;
  }
  
  public int getDay() {
    return day;
  }
  
  public void setYear(int year) {
    this.year = year;
    localDT = LocalDateTime.of(year, month, day, 0, 0);
  }
  
  public void setMonth(int month) {
    this.month = month;
    localDT = LocalDateTime.of(year, month, day, 0, 0);
  }
  
  public void setDay(int day) {
    this.day = day;
    localDT = LocalDateTime.of(year, month, day, 0, 0);
  }

public String toString() {
	return "MyDate [year=" + year + ", month=" + month + ", day=" + day + "]";
}  
  
  
}