/*
 * @lc app=leetcode id=136 lang=csharp
 *
 * [136] Single Number
 */

// @lc code=start
public class Solution {
    public int SingleNumber(int[] nums) {
        Array.Sort(nums);
        for(var i = 0; i < nums.Length; i+=2)
        {
            if(i + 1 == nums.Length) return nums[i];
            if(nums[i] != nums[i + 1]) return nums[i];
        }
        return 0;
    }
}
// @lc code=end

