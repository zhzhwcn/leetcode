﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new[] { 4, 1, 2, 1, 2 };
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
            Console.WriteLine(new Solution().ConvertToTitle(27));
        }
    }

    public class Solution
    {
        public string ConvertToTitle(int n)
        {
            var result = "";
            while (n > 0)
            {
                var mod = n % 26;
                if (mod == 0)
                {
                    mod = 26;
                }
                result = ((char) (mod + 64)).ToString() + result;
                n = (n - mod) / 26;
            }
            

            return result;
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

    public class MinStack
    {

        /** initialize your data structure here. */
        private Stack<int> _stack;
        public MinStack()
        {
            _stack = new Stack<int>();
        }

        public void Push(int x)
        {
            _stack.Push(x);
        }

        public void Pop()
        {
            _stack.Pop();
        }

        public int Top()
        {
            return _stack.FirstOrDefault();
        }

        public int GetMin()
        {
            return _stack.Min();
        }
    }

}
