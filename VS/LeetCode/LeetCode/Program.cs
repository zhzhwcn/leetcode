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
            var r = new[] { 9 };
            var a = "1";
            var b = "11";
            var p = new TreeNode(1);
            var pl = new TreeNode(2);
            p.left = pl;
            var pr = new TreeNode(3);
            p.right = pr;
            var q = new TreeNode(1);
            var ql = new TreeNode(2);
            q.left = ql;
            var qr = new TreeNode(3);
            q.right = qr;
            Console.WriteLine(new Solution().IsSameTree(p, q));
        }
    }

    public class Solution
    {
        public static Dictionary<int, int> cache = new Dictionary<int, int>();
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if ((p == null && q != null) || p != null && q == null) return false;
            if (p == null && q == null) return true;
            if (p.val != q.val) return false;
            if (IsSameTree(p?.left, q?.left)) return IsSameTree(p?.right, q?.right);
            return false;
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
