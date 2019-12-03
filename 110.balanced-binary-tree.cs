/*
 * @lc app=leetcode id=110 lang=csharp
 *
 * [110] Balanced Binary Tree
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
    public bool IsBalanced(TreeNode root)
    {
        if (root == null) return true;
        var left = Height(root.left);
        var right = Height(root.right);
        return Math.Abs(left - right) <= 1 && IsBalanced(root.left) && IsBalanced(root.right);
    }

    public int Height(TreeNode node)
    {
        if (node == null) return 0;
        return 1 + Math.Max(Height(node.left), Height(node.right));
    }
}
// @lc code=end

