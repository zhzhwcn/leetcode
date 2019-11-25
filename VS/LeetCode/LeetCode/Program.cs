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
        public int ClimbStairs(int n)
        {
            if (n == 1) return 1;
            if (n == 2) return 2;
            if (cache.ContainsKey(n)) return cache[n];
            var s = this.ClimbStairs(n - 1) + this.ClimbStairs(n - 2);
            cache[n] = s;
            return s;
        }
    }
}
