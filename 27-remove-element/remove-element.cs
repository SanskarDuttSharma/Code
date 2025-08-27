public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int p1 = 0;
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] != val){
                nums[p1] = nums[i];
                p1++;
            }
        }
        return p1;
    }
}