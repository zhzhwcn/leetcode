/*
 * @lc app=leetcode id=9 lang=csharp
 *
 * [9] Palindrome Number
 */

// @lc code=start
public class Solution {
    public bool IsPalindrome(int x) {
        var str = x.ToString();
        return new string(str.Reverse().ToArray()) == str;
    }
}
// @lc code=end

