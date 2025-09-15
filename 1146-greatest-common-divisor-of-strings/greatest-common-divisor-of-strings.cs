public class Solution {
    public string GcdOfStrings(string str1, string str2) {
        if((str1+str2) != (str2+str1))
        {
            return "";
        }
        int gcd = GCD(str1.Length, str2.Length);

        return str1.Substring(0, gcd);

    }

    private int GCD(int str1, int str2){
        while(str2 != 0){
            int temp = str2;
            str2 = str1 % str2;
            str1 = temp;
        }
        return str1;
    }
}