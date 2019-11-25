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
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            Array.Copy(nums2, 0, nums1, m, nums2.Length);
            Array.Sort(nums1);
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
