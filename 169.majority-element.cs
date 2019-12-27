/*
 * @lc app=leetcode id=169 lang=csharp
 *
 * [169] Majority Element
 */

// @lc code=start
public class Solution {
    public int MajorityElement(int[] nums) {
        Array.Sort(nums);
        var half = nums.Length / 2;
        var current = nums[0];
        var count = 1;
        for(var i = 1; i < nums.Length; i++){
            if(current == nums[i]) {
                count++;
            } else {
                if(count > half) return current;
                else
                {
                    current = nums[i];
                    count = 1;
                }
            }
        }
        return current;
    }
}
// @lc code=end

