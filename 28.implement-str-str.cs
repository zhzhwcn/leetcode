/*
 * @lc app=leetcode id=28 lang=csharp
 *
 * [28] Implement strStr()
 */

// @lc code=start
public class Solution {
    public int StrStr(string haystack, string needle) {
        if(string.IsNullOrEmpty(needle)) return 0;
        return haystack.IndexOf(needle);
    }
}
// @lc code=end

