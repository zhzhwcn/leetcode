/*
 * @lc app=leetcode id=14 lang=csharp
 *
 * [14] Longest Common Prefix
 */

// @lc code=start
public class Solution {
    public string LongestCommonPrefix(string[] strs) {
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
// @lc code=end

