/*
 * @lc app=leetcode id=58 lang=csharp
 *
 * [58] Length of Last Word
 */

// @lc code=start
public class Solution {
    public int LengthOfLastWord(string s) {
        var words = s.Trim().Split(' ');
        var last = words.LastOrDefault();
        return last?.Length ?? 0;
    }
}
// @lc code=end

