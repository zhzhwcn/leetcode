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
            Console.WriteLine(new Solution().ClimbStairs(44));
        }
    }

    public class Solution
    {
        public static Dictionary<int, int> cache = new Dictionary<int, int>();
        public ListNode DeleteDuplicates(ListNode head)
        {
            var node = head;
            while (node.next != null)
            {
                if(node.next.val == node.val)
                {
                    node.next = node.next.next;
                }
                else
                {
                    node = node.next;
                }
            }
            return head;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
