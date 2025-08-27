public class Solution {
    public int StrStr(string haystack, string needle) {
        int lenHayStack = haystack.Length;
        int lenNeedle = needle.Length;

        if(lenNeedle == 0){
            return 0;
        }

        if( lenHayStack < lenNeedle){
            return -1;
        }

        for(int i = 0; i <= (lenHayStack - lenNeedle) ; i++){
            if(haystack.Substring(i, lenNeedle) == needle){
                return i;
            }
        }
        return -1;
    }
}