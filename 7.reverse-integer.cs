/*
 * @lc app=leetcode id=7 lang=csharp
 *
 * [7] Reverse Integer
 */
// @lc code=start
public class Solution {
    public int Reverse(int x) {
        if (x >= Int32.MaxValue || x <= Int32.MinValue)
        {
            return 0;
        }
        var n = x < 0;
        x = Math.Abs(x);
        long result = 0;
        while(x > 0){
            result = result * 10 + x % 10;
            x = x / 10;
        }
        if(result > Int32.MaxValue || result < Int32.MinValue)
        {
            return 0;
        }
        return (Int32)(n ? -result : result);
    }
}
// @lc code=end

