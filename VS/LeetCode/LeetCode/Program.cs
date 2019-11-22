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
            Console.WriteLine(new Solution().AddBinary(a, b));
        }
    }

    public class Solution
    {
        public string AddBinary(string a, string b)
        {
            var array1 = a.ToCharArray().Select(x => (int)(x - '0')).ToArray();
            var array2 = b.ToCharArray().Select(x => (int)(x - '0')).ToArray();
            var sb = new StringBuilder();
            var index1 = array1.Length;
            var index2 = array2.Length;
            int b1 = 0, b2 = 0, plus = 0;
            while (true)
            {
                if(--index1 >= 0)
                {
                    b1 = array1[index1];
                }
                else
                {
                    b1 = 0;
                }
                if(--index2 >= 0)
                {
                    b2 = array2[index2];
                }
                else
                {
                    b2 = 0;
                }
                var sum = b1 + b2 + plus;
                plus = 0;
                if (sum >= 2)
                {
                    sum %= 2;
                    plus = 1;
                }
                if (index1 < -1 && index2 < -1) break;
                sb.Append(sum);
            }
            if (plus > 0) sb.Append(plus);
            var str = sb.ToString().TrimEnd('0');
            if (string.IsNullOrEmpty(str)) str = "0";
            return new String(str.Reverse().ToArray());
        }
    }
}
