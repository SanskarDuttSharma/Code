public class Solution {
    //pallindrome
    public bool IsPalindrome(int x) {
        if(x<0){
            return false;
        }
        int rev = 0, y = x;
        while(y!=0){
            rev = rev*10 + y%10;
            y=y/10;
        }
        return (x == rev) ? true : false;
    }
}