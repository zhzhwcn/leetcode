/*
 * @lc app=leetcode id=125 lang=csharp
 *
 * [125] Valid Palindrome
 */

// @lc code=start
public class Solution {
    public bool IsPalindrome(string s) {
        var chars = s.ToLower().ToCharArray();
        var start = 0;
        var end = chars.Length - 1;
        while (start < end)
        {
            while(start < chars.Length)
            {
                if ((chars[start] >= 97 && chars[start] <= 122) || (chars[start] >= 48 && chars[start] <= 57)) break;
                start++;
            }
            while(end >= 0)
            {
                if ((chars[end] >= 97 && chars[end] <= 122) || (chars[end] >= 48 && chars[end] <= 57)) break;
                end--;
            }
            if (start > end) return true;
            if (chars[start] != chars[end])
            {
                return false;
            }
            start++;
            end--;
        }
        return true;
    }
}
// @lc code=end

