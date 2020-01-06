import java.io.Console;
import java.lang.String;
import java.lang.StringBuilder;
import java.util.regex.Pattern;
import java.util.regex.Matcher;

class CalcIps {
    private static String zeros = "00000000";
    private StringBuilder resultStr = new StringBuilder(8);
    private static Console console = System.console();
    private String inIpStr = "";
    private String ipClass = "";
    private String ipRoute = "";
    private String ipClassMaskStr = "";
    private String ipClassSlash = "";
    private int[] intIpArray = new int[4];
    private String[] binIpStrArray = new String[4];
    private byte[] byteIpArray = new byte[4];
    private int[] intClassMaskArray = new int[4];
    private String[] binClassMaskStrArray = new String[4];
    private byte[] byteClassMaskArray = new byte[4];

    public void setBinaryClassMaskStrFromInt() {
        int i = 0;
        int leadingZeros = 0;
        String[] octet = ipClassMaskStr.split("[.]");   
        for(String x : octet) { 
            intClassMaskArray[i] = Integer.valueOf(x);             
            i++;
        }
        i = 0;
        for(int x : intClassMaskArray) {
            resultStr.setLength(0);
            String binStr = Integer.toBinaryString(x);
            leadingZeros = Integer.numberOfLeadingZeros(x) - 24;
            String leader = zeros.substring(0, leadingZeros);
            resultStr = resultStr.insert(0,leader);
            resultStr = resultStr.append(binStr);
            binClassMaskStrArray[i] = resultStr.substring(0);
            console.format("%nClass Mask %d at position %d = %s",x,i,binClassMaskStrArray[i]);
            byteClassMaskArray[i] = Integer.valueOf(x).byteValue();
            i++;
        }
        console.format("%nipClass = %s %nipClassMask = %s %nipClassSlash = %s %nipRoute = %s",ipClass, ipClassMaskStr, ipClassSlash, ipRoute);
    }
    public void setClass() {
        if (intIpArray[0] >= 0 && intIpArray[0] <= 127) {
            ipClass = "A";
            ipClassMaskStr = "255.0.0.0";
            ipClassSlash = "8";
            if (intIpArray[0] == 0 || intIpArray[0] == 10 || intIpArray[0] == 127 ) 
                ipRoute = "Private";
            else ipRoute = "Routable";
        } else if (intIpArray[0] >= 128 && intIpArray[0] <= 191) {
            ipClass = "B";
            ipClassMaskStr = "255.255.0.0";
            ipClassSlash = "16";
            if (intIpArray[0] == 169 && intIpArray[1] == 254) {
                ipRoute = "APIPA";
            } else if (intIpArray[0] == 172 && intIpArray[1] >= 16 && intIpArray[1] <= 31)
                ipRoute = "Private";
            else ipRoute = "Routable";
        } else if (intIpArray[0] >= 192 && intIpArray[0] <=223) {
            ipClass = "C";
            ipClassMaskStr = "255.255.255.0";
            ipClassSlash = "24";
            if (intIpArray[0] == 192 && intIpArray[1] == 168)
                ipRoute = "Private";
            else ipRoute = "Routable";
        } else if (intIpArray[0] >= 224 && intIpArray[0] <= 255) {
            ipClass = "D";
            if (intIpArray[0] >= 240)
                ipClass = "E";
                ipClassMaskStr = "0.0.0.0";
            ipClassSlash = "0";
            ipRoute = "Reserved";
        }
        setBinaryClassMaskStrFromInt();
    }
    public void setBinaryIpOctetStrFromInt() {
        int i = 0;
        int leadingZeros = 0;
        for(int x : intIpArray) {
            resultStr.setLength(0);
            String binStr = Integer.toBinaryString(x);
            leadingZeros = Integer.numberOfLeadingZeros(x) - 24;
            String leader = zeros.substring(0, leadingZeros);
            resultStr = resultStr.insert(0,leader);
            resultStr = resultStr.append(binStr);
            binIpStrArray[i] = resultStr.substring(0);
            console.format("%n%d at position %d is %s",x,i,binIpStrArray[i]);
            byteIpArray[i] = Integer.valueOf(x).byteValue();
            i++;
        }
    }
    public void setIntOctetsFromStr (String inIpStr) {
        String[] octet = inIpStr.split("[.]");
        int i = 0;     
        for(String x : octet) { 
            intIpArray[i] = Integer.valueOf(x);             
            i++;
        }
    }
    public static boolean validateInputIp(final String inIpStr) {
        Pattern p = Pattern.compile("^((0|1\\d?\\d?|2[0-4]?\\d?|25[0-5]?|[3-9]\\d?)\\.){3}(0|1\\d?\\d?|2[0-4]?\\d?|25[0-5]?|[3-9]\\d?)$");
        Matcher m = p.matcher(inIpStr);
        return m.matches();
    }
    public void getInputIp() {
        inIpStr = console.readLine("%nEnter an IP Address: ");
        if (validateInputIp(inIpStr)) {
            setIntOctetsFromStr(inIpStr);
            setBinaryIpOctetStrFromInt();
            setClass();
        } else
            console.format("%nIP Address %s is invalid",inIpStr);        
    }
    public static void main(String args[]) {
        CalcIps calcips = new CalcIps();
        calcips.getInputIp();
        System.exit(0);
    }
    public void testCalc() {
        int intNum = Integer.valueOf(console.readLine("%nNumber: "));
        String binStr = Integer.toBinaryString(Integer.valueOf(intNum));
        console.format("%n%d = %s", intNum, binStr); 
        int highest = Integer.highestOneBit(intNum);
        console.format("%nhighest bit is %d", highest);
        int leadingZeros = Integer.numberOfLeadingZeros(intNum) - 24;
        console.format("%nnumber of leading zeros is %d", leadingZeros);
        String leader = zeros.substring(0,leadingZeros);
        resultStr = resultStr.insert(0,leader);
        resultStr = resultStr.append(binStr);
        console.format("%nbinary is %s",resultStr);
    }
}