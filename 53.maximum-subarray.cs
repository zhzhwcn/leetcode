/*
 * @lc app=leetcode id=53 lang=csharp
 *
 * [53] Maximum Subarray
 */

// @lc code=start
public class Solution {
    public int MaxSubArray(int[] nums) {
        var maxResult = int.MinValue;
        var sum = nums[0];
        if(nums.Length == 1) return sum;
        for(var i = 1; i <= nums.Length; i++)
        {
            sum += nums[i];
            if(nums[i] > sum) sum = nums[i];
            if(sum > maxResult) maxResult = sum;
        }
        return maxResult;
    }
}
// @lc code=end

