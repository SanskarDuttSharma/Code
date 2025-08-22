using System.Collections.Generic;

public class Solution {
    //two sum
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++){
            int difference = target - nums[i];

            if(map.ContainsKey(difference)){
                return new int[]{i,map[difference]};
            }

            if(!map.ContainsKey(nums[i])){
                map[nums[i]] = i;
            }
        }
        return null;
    }
}