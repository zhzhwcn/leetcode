/*
 * @lc app=leetcode id=88 lang=csharp
 *
 * [88] Merge Sorted Array
 */

// @lc code=start
public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        Array.Copy(nums2, 0, nums1, m, nums2.Length);
        Array.Sort(nums1);
    }
}
// @lc code=end

