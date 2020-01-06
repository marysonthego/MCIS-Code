package networkconfig;

/* Mary Clark
*  April, 2019
*/

public class NetworkConfig {

    private int[] ipAddr;
    private String[] ipOctets;
    private String[] ipNibbles;

    private String[] classOctets;
    private String[] classNetmaskNibbles;
    private char classLetter;
    private char nominalClass;
    private String slashClass;

    private int[] networkNetmaskAddr;
    private String[] networkOctets;
    private String[] networkNibbles;
    private String slashNetwork;

    private int[] subnetNetmaskAddr;
    private String[] subnetOctets;
    private String[] subnetNibbles;
    private String slashSubnet;

    static private int[] zeroAddr = {0,0,0,0};
    static private String[] zeroOctets = {"00000000","00000000","00000000","00000000"};
    static private String[] zeroNibbles = {"0000 0000","0000 0000","0000 0000","0000 0000"};


    NetworkConfig() {
        ipAddr = new int[4];
        ipOctets = new String[4];
        ipNibbles = new String[4];

        classOctets = new String[4];
        classNetmaskNibbles = new String[4];
        classLetter = ' ';
        nominalClass = ' ';
        slashClass = " ";

        networkNetmaskAddr = new int[4];
        networkOctets = new String[4];
        networkNibbles = new String[4];
        slashNetwork = " ";

        subnetNetmaskAddr = new int[4];
        subnetOctets = new String[4];
        subnetNibbles = new String[4];
        slashSubnet = " ";
    }

    public int[] getAddress(String type) {
        switch (type) {
            case "ip address":
                return ipAddr;
            case "network":
                return networkNetmaskAddr;
            case "subnet":
                return subnetNetmaskAddr;
            default:
                return zeroAddr;
        }
    }

    public boolean setAddress(int[] addr, String type) {
        switch (type) {
            case "ip address":
                ipAddr = addr.clone();
                setNetworkClass();
                break;
            case "network":
                networkNetmaskAddr = addr.clone();
                break;
            case "subnet":
                subnetNetmaskAddr = addr.clone();
                break;
            default:
                return false;
        }
        return true;
    }

       private void setNetworkClass() {
        if (ipAddr[0] == 10) {
            classLetter = 'P';
            nominalClass = 'A';
            setClassOctetsandNibbles(nominalClass);

        } else if ((ipAddr[0] == 172) && (ipAddr[1] > 15 && ipAddr[1] < 32)) {
            classLetter = 'P';
            nominalClass = 'B';
            setClassOctetsandNibbles(nominalClass);

        } else if ((ipAddr[0] == 192) && (ipAddr[1] == 168)) {
            classLetter = 'P';
            nominalClass = 'C';
            setClassOctetsandNibbles(nominalClass);
        } else if (ipAddr[0] < 128) {
            classLetter = 'A';
            setClassOctetsandNibbles(classLetter);

        } else if (ipAddr[0] < 192) {
            classLetter = 'B';
            setClassOctetsandNibbles(classLetter);
        } else if (ipAddr[0] < 224) {
            classLetter = 'C';
            setClassOctetsandNibbles(classLetter);

        } else  if (ipAddr[0] < 240) {
            classLetter = 'D';
            setClassOctetsandNibbles(classLetter);

        } else {
            classLetter = 'E';
            setClassOctetsandNibbles(classLetter);
        }
    }

    public String getClassSlash() {
        return slashClass;
    }

    private void setClassSlash(char theClass) {
        switch (theClass) {
            case 'A':
                slashClass = "/8";
            case 'B':
                slashClass = "/16";
            case 'C':
                slashClass = "/24";
            case 'D':
                slashClass = "/32";
            case 'E':
                slashClass = "/0";
            default:
                slashClass = "/ ";
        }
    }

    public String[] getClassOctets() {
        return classOctets;
    }

    private void setClassOctetsandNibbles(char letter) {

        for (int i=0; i<classOctets.length; i++) {
            classOctets[i] = "00000000";
            classNetmaskNibbles[i] = "0000 0000";
        }
        if (letter == 'E' || letter == 'P') {
            return;
        }
        if (letter == 'A' || letter == 'B' || letter == 'C') {
            classOctets[0] = "11111111";
            classNetmaskNibbles[0] = "1111 1111";
        }
        if (letter == 'B' || letter == 'C') {
            classOctets[1] = "11111111";
            classNetmaskNibbles[1] = "1111 1111";
        }
        if (letter == 'C') {
            classOctets[2] = "11111111";
            classNetmaskNibbles[2] = "1111 1111";
        }
        if (letter == 'D') {
            classOctets[3] = "11111111";
            classNetmaskNibbles[3] = "1111 1111";
        }
        setClassSlash(letter);
    }

    public char getNetworkClass() {
        return classLetter;
    }

    public String[] getClassNibbles() {
        return classNetmaskNibbles;
    }

    public String getClassNetMaskNibble(int position) {
        return classNetmaskNibbles[position];
    }

    public String[] getBinaryOctets(String type) {
        switch (type) {
            case "ip address":
                return ipOctets;
            case "network":
                return networkOctets;
            case "subnet":
                return subnetOctets;
            default:
                return zeroOctets;
        }
    }

    public String[] getNibbles(String type) {
        int z = 0;
        if (type.equals("ip address")) {
            for (int b=0; b<ipOctets.length; b++) {
                String bitString = ipOctets[b];
                z = 8 - ipOctets[b].length();
                for (int a = 0; a<z; a++) {
                    bitString = "0" + bitString;
                }
            ipNibbles[b]=bitString.substring(0,4) + " " + bitString.substring(4,8);
            }
            return ipNibbles;
        } else if (type.equals("network")) {
            for (int b=0; b<networkOctets.length; b++) {
                String bitString = networkOctets[b];
                z = 8 - networkOctets[b].length();
                for (int a = 0; a<z; a++) {
                   bitString = "0" + bitString;
                }
            networkNibbles[b]=bitString.substring(0,4) + " " + bitString.substring(4,8);
            }
            return networkNibbles;
        } else if (type.equals("subnet")) {
               for (int b=0; b<subnetOctets.length; b++) {
                    String bitString = subnetOctets[b];
                    z = 8 - subnetOctets[b].length();
                    for (int a = 0; a<z; a++) {
                        bitString = "0" + bitString;
                    }
            subnetNibbles[b]=bitString.substring(0,4) + " " + bitString.substring(4,8);
            }
            return subnetNibbles;
        }
        return zeroNibbles;
    }

    public void setOctet(int anOctet, int position, String type) {
        if (type.equals("ip address")) {
            ipAddr[position] = anOctet;
            ipOctets[position] = Integer.toBinaryString(anOctet);
        } else if (type.equals("network")) {
            networkNetmaskAddr[position] = anOctet;
            networkOctets[position] = Integer.toBinaryString(anOctet);
        } else if (type.equals("subnet")) {
            subnetNetmaskAddr[position] = anOctet;
            subnetOctets[position] = Integer.toBinaryString(anOctet);
        }
    }
}
