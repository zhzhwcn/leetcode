/*
 * @lc app=leetcode id=108 lang=csharp
 *
 * [108] Convert Sorted Array to Binary Search Tree
 */

// @lc code=start
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public TreeNode SortedArrayToBST(int[] nums) {
        return sortedArrayToBST(nums, 0, nums.Length-1);
    }

    public TreeNode sortedArrayToBST(int[] nums, int low, int high){
        if(high < low) return null;
        var mid = low + (int)Math.Ceiling((high - low) / 2D);
        TreeNode root = new TreeNode(nums[mid]);
        root.left = sortedArrayToBST(nums, low, mid-1);
        root.right = sortedArrayToBST(nums, mid+1, high);
        return root;
    }
}
// @lc code=end

