/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 */

// @lc code=start
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for(var i = 0; i < nums.Length; i++){
            for(var j = 0; j < nums.Length; j++){
                if (i == j) continue;
                if(nums[i] + nums[j] == target){
                    return new [] {i, j};
                }
            }
        }
        return new int[2];
    }
}
// @lc code=end

