/*
 * @lc app=leetcode id=107 lang=csharp
 *
 * [107] Binary Tree Level Order Traversal II
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
    public IList<IList<int>> List = new List<IList<int>>();
    public IList<IList<int>> LevelOrderBottom(TreeNode root)
    {
        LevelOrderBottom(root, 0);
        return List.Reverse().ToList();
    }
    public void LevelOrderBottom(TreeNode root, int level)
    {
        if (root == null) return;
        if (List.Count <= level) List.Add(new List<int>());
        List[level].Add(root.val);
        LevelOrderBottom(root.left, level + 1);
        LevelOrderBottom(root.right, level + 1);
    }
}
// @lc code=end

