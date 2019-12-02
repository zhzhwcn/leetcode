/*
 * @lc app=leetcode id=104 lang=csharp
 *
 * [104] Maximum Depth of Binary Tree
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
    public int MaxDepth(TreeNode root) {
        return MaxDepth(root, 0);
    }

    public int MaxDepth(TreeNode node, int level)
    {
        if(node == null) return level;
        var left = MaxDepth(node.left, level + 1);
        var right = MaxDepth(node.right, level+ 1);
        return left > right ? left : right;
    }
}
// @lc code=end

