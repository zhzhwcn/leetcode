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
            Console.WriteLine(new Solution().RemoveDuplicates(r));
        }
    }

    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            var length = nums.Distinct().Count();
            Array.Copy(nums.Distinct().ToArray(), nums, length);
            
            return length;
        }
    }
}
