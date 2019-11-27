/*
 * @lc app=leetcode id=100 lang=csharp
 *
 * [100] Same Tree
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
    public bool IsSameTree(TreeNode p, TreeNode q) {
        if((p == null && q != null) || p != null && q == null) return false;
        if (p == null && q == null) return true;
        if(p.val != q.val) return false;
        if(IsSameTree(p?.left, q?.left)) return IsSameTree(p?.right, q?.right);
        return false;
    }
}
// @lc code=end
public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }
}
