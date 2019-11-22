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
            Console.WriteLine(new Solution().CountAndSay(5));
        }
    }

    public class Solution
    {
        public string CountAndSay(int n)
        {
            var start = "1";
            if (n == 1)
            {
                return start;
            }
            //start = "11";
            for (var i = 2; i <= n; i++)
            {
                var charArray = start.ToCharArray();
                var sb = new StringBuilder();
                var count = 1;
                var lastChar = charArray[0];
                for (var j = 0; j < charArray.Length - 1; j++)
                {
                    if (charArray[j] != charArray[j + 1])
                    {
                        sb.Append(count);
                        sb.Append(charArray[j]);
                        count = 1;
                        lastChar = charArray[j + 1];
                    }
                    else
                    {
                        count++;
                    }
                }
                sb.Append(count);
                sb.Append(lastChar);
                start = sb.ToString();
                if (i == n) return start;
            }
            return "";
        }
    }
}
