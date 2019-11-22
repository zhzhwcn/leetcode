/*
 * @lc app=leetcode id=66 lang=csharp
 *
 * [66] Plus One
 */

// @lc code=start
public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        var last = digits.Length - 1;
        while (last >= 0 && digits[last] == 9)
        {
            digits[last] = 0;
            last--;
        }
        if (last < 0)
        {
            Array.Resize(ref digits, digits.Length + 1);
            last = 0;
        }
        digits[last]++;
        return digits;
    }
}
// @lc code=end

