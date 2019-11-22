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
            Console.WriteLine(new Solution().PlusOne(r));
        }
    }

    public class Solution
    {
        public int[] PlusOne(int[] digits)
        {
            var last = digits.Length - 1;
            while (last >= 0 && digits[last] == 9)
            {
                digits[last] = 0;
                last--;
            }
            if(last < 0)
            {
                Array.Resize(ref digits, digits.Length + 1);
                last = 0;
            }
            digits[last]++;
            return digits;
        }
    }
}
