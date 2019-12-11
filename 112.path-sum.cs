/*
 * @lc app=leetcode id=112 lang=csharp
 *
 * [112] Path Sum
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
    public bool HasPathSum(TreeNode root, int sum)
    {
        if (root == null) return false;
        sum -= root.val;
        if (sum == 0 && root.left == null && root.right == null) return true;
        return HasPathSum(root.left, sum) || HasPathSum(root.right, sum);
    }
}
// @lc code=end

