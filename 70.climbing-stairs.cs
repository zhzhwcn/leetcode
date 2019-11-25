/*
 * @lc app=leetcode id=70 lang=csharp
 *
 * [70] Climbing Stairs
 */

// @lc code=start
public class Solution {
    public static Dictionary<int, int> cache = new Dictionary<int, int>(); 
        public int ClimbStairs(int n)
        {
            if (n == 1) return 1;
            if (n == 2) return 2;
            if (cache.ContainsKey(n)) return cache[n];
            var s = this.ClimbStairs(n - 1) + this.ClimbStairs(n - 2);
            cache[n] = s;
            return s;
        }
}
// @lc code=end

