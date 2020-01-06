package networkconfig;

/* Mary Clark
*  April, 2019
*/

class NetworkConfig {

    private int[] octets;
    private String[] binaryOctets;
    private String[] nibbles;

    private String[] classNetmask;
    private String[] classNetmaskNibbles;
    private char netPrefixClass;

    private int[] primaryNetmaskOctets;
    private String[] primaryBinaryOctets;
    private String[] primaryNibbles;

    private int[] subnetNetmaskOctets;
    private String[] subnetBinaryOctets;
    private String[] subnetNibbles;

    NetworkConfig() {
        octets = new int[4];
        binaryOctets = new String[4];
        nibbles = new String[4];

        primaryNetmaskOctets = new int[4];
        primaryBinaryOctets = new String[4];
        primaryNibbles = new String[4];

        subnetNetmaskOctets = new int[4];
        subnetBinaryOctets = new String[4];
        subnetNibbles = new String[4];

        netPrefixClass = 'R';
        setClassNetmasks(netPrefixClass);
    }

    public char getNetworkPrefixClass() {
        if (octets[0] == 10) {
            netPrefixClass = 'P';
            setClassNetmasks(netPrefixClass);
            return 'P';
        } else if ((octets[0] == 172) && (octets[1] > 15 && octets[1] < 32)) {
            netPrefixClass = 'P';
            setClassNetmasks(netPrefixClass);
            return 'P';
        } else if ((octets[0] == 192) && (octets[1] == 168)) {
            netPrefixClass = 'P';
            setClassNetmasks(netPrefixClass);
            return 'P';
        } else if (octets[0] < 128) {
            netPrefixClass = 'A';
            setClassNetmasks(netPrefixClass);
            return 'A';
        } else if (octets[0] < 192) {
            netPrefixClass = 'B';
            setClassNetmasks(netPrefixClass);
            return 'B';
        } else if (octets[0] < 224) {
            netPrefixClass = 'C';
            setClassNetmasks(netPrefixClass);
            return 'C';
        } else {
            netPrefixClass = 'R';
            setClassNetmasks(netPrefixClass);
            return 'R';
        }
    }

    public String[] getClassNetmask() {
        return classNetmask;
    }

    public String[] getClassNetmaskNibbles() {
        return classNetmaskNibbles;
    }
    
    public String getClassNetMaskNibble(int position) {
        return classNetmaskNibbles[position];
    }

    public int[] getOctets(String type) {
        if (type.equals("initial")) {
            return octets;
        } else if (type.equals("primary")) {
            return primaryNetmaskOctets;
        } else if (type.equals("subnet")) {
            return subnetNetmaskOctets;
        }
        return octets;
    }

    public String[] getBinaryOctets(String type) {
        if (type.equals("initial")) {
         return binaryOctets;
        } else if (type.equals("primary")) {
            return primaryBinaryOctets;
        } else if (type.equals("subnet")) {
            return subnetBinaryOctets;
        }
        return binaryOctets;
    }

    public String[] getNibbles(String type) {
        int z = 0;
        if (type.equals("initial")) {
        for (int b=0; b<binaryOctets.length; b++) {
            String bitString = binaryOctets[b];
            z= 8 - binaryOctets[b].length();
            for (int a = 0; a< z; a++) {
                bitString = "0" + bitString;
            }
            nibbles[b]=bitString.substring(0,4) + " " + bitString.substring(4,8);
        }

        } else if (type.equals("primary")) {
               for (int b=0; b<primaryBinaryOctets.length; b++) {
                   String bitString = primaryBinaryOctets[b];
                   z= 8 - primaryBinaryOctets[b].length();
                   for (int a = 0; a< z; a++) {
                       bitString = "0" + bitString;
                   }
                nibbles[b]=bitString.substring(0,4) + " " + bitString.substring(4,8);
                }
        } else if (type.equals("subnet")) {
               for (int b=0; b<subnetBinaryOctets.length; b++) {
                    String bitString = subnetBinaryOctets[b];
                    z= 8 - subnetBinaryOctets[b].length();
                    for (int a = 0; a< z; a++) {
                        bitString = "0" + bitString;
                    }
                nibbles[b]=bitString.substring(0,4) + " " + bitString.substring(4,8);
                }
            }
        return nibbles;
    }

    private void setClassNetmasks(char c) {
        classNetmask = new String[4];
        classNetmaskNibbles = new String[4];

        for (int i=0; i<classNetmask.length; i++) {
            classNetmask[i] = "00000000";
            classNetmaskNibbles[i] = "0000 0000";
        }
        if (c == 'R') {
            return;
        }
        if (c == 'A' || c == 'B' || c == 'C') {
            classNetmask[0] = "11111111";
            classNetmaskNibbles[0] = "1111 1111";
        }
        if (c == 'B' || c == 'C') {
            classNetmask[1] = "11111111";
            classNetmaskNibbles[1] = "1111 1111";
        }
        if (c == 'C') {
            classNetmask[2] = "11111111";
            classNetmaskNibbles[2] = "1111 1111";
        }
    }

    public void setOctet(int anOctet, int position, String type) {
        if (type.equals("initial")) {
            octets[position] = anOctet;
            binaryOctets[position] = Integer.toBinaryString(anOctet);
        }
        else if (type.equals("primary")) {
            primaryNetmaskOctets[position] = anOctet;
            primaryBinaryOctets[position] = Integer.toBinaryString(anOctet);
        } else if (type.equals("subnet")) {
            subnetNetmaskOctets[position] = anOctet;
            subnetBinaryOctets[position] = Integer.toBinaryString(anOctet);
        }

    }

    /* private void setAllOctets(int[] oArray) {
        System.arraycopy(oArray, 0, octets, 0, oArray.length);
    }

    private void setBinaryOctet(String s, int position) {
        binaryOctets[position] = s;
    }

    private void setAllBinaryOctets(String[] sArray) {
        System.arraycopy(sArray, 0, binaryOctets, 0, sArray.length);
    }
*/
}
