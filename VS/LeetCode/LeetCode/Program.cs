using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new[] { -10, -3, 0, 5, 9 };
            var a = "1";
            var b = "11";
            var p = new TreeNode(1);
            var pl = new TreeNode(2);
            p.left = pl;
            var pr = new TreeNode(2);
            p.right = pr;
            var p2l1 = new TreeNode(3);
            pl.left = p2l1;
            var p2r1 = new TreeNode(4);
            pl.right = p2r1;
            var p2l2 = new TreeNode(4);
            pr.left = p2l2;
            var p2r2 = new TreeNode(3);
            pr.right = p2r2;
            var q = new TreeNode(1);
            var ql = new TreeNode(2);
            q.left = ql;
            var qr = new TreeNode(3);
            q.right = qr;
            Console.WriteLine(new Solution().MinDepth(q));
        }
    }

    public class Solution
    {
        public int MinDepth(TreeNode root)
        {
            if (root == null) return 0;
            int Calc(TreeNode node)
            {
                if (root.left == null && root.right == null) return 1;
                return 1 + Math.Min(MinDepth(root.left), MinDepth(root.right));
            }
            return Calc(root);
            
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

}
