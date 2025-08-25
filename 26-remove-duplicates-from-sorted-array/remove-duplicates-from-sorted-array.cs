public class Solution {
    //remove dup
    public int RemoveDuplicates(int[] nums) {
        if(nums.Length == 1){
            return 1;
        }

        int p1 = 0;
        int p2 = 1;

        while(p2 < nums.Length){
            if(nums[p1] < nums[p2]){
                int t = nums[p1+1];
                nums[p1+1] = nums[p2];
                nums[p2] = t;
                p1 = p1+1;
            }
            p2 = p2+1;
        }

        return p1+1;
    }
}