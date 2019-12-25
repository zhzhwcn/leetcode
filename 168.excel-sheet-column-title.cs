/*
 * @lc app=leetcode id=168 lang=csharp
 *
 * [168] Excel Sheet Column Title
 */

// @lc code=start
public class Solution {
    public string ConvertToTitle(int n) {
        var result = "";
        while (n > 0)
        {
            var mod = n % 26;
            if (mod == 0)
            {
                mod = 26;
            }
            result = ((char) (mod + 64)).ToString() + result;
            n = (n - mod) / 26;
        }


        return result;
    }
}
// @lc code=end

