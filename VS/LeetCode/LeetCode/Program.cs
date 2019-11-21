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
            var r = new[] { 0, 0, 1,1, 1, 2, 2,3,3,4};
            Console.WriteLine(new Solution().RemoveElement(r, 2));
        }
    }

    public class Solution
    {
        public int RemoveElement(int[] nums, int val)
        {
            var list = nums.ToList();
            list.RemoveAll(x => x == val);
            Array.Copy(list.ToArray(), nums, list.Count);
            return list.Count;
        }
    }
}
