using System;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new[] { "flower", "flow", "flight" };
            Console.WriteLine(new Solution().LongestCommonPrefix(r));
        }
    }

    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0) return "";
            Array.Sort(strs);
            var first = strs[0].ToCharArray();
            var last = strs[strs.Length - 1].ToCharArray();
            var sb = new StringBuilder();
            for(var i = 0; i < first.Length; i++)
            {
                if (first[i] == last[i]) sb.Append(first[i]);
                else break;
            }
            return sb.ToString();
        }
    }
}
