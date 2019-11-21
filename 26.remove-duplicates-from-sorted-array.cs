/*
 * @lc app=leetcode id=26 lang=csharp
 *
 * [26] Remove Duplicates from Sorted Array
 */

// @lc code=start
using System.Linq;
public class Solution {
    public int RemoveDuplicates(int[] nums) {
        var length = nums.Distinct().Count();
            Array.Copy(nums.Distinct().ToArray(), nums, length);
            return length;
    }
}
// @lc code=end

