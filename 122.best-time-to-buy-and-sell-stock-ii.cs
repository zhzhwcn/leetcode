/*
 * @lc app=leetcode id=122 lang=csharp
 *
 * [122] Best Time to Buy and Sell Stock II
 */

// @lc code=start
public class Solution {
    public int MaxProfit(int[] prices) {
        if(prices.Length <= 1) return 0;
        var profit = 0;
        var min = prices[0];
        var max = 0;
        for(var i = 1; i < prices.Length; i++) {
            max = Math.Max(max, prices[i] - min);
            min = Math.Min(min, prices[i]);
            if(i < prices.Length -1 && prices[i] > prices[i + 1]){
                profit += max;
                max = 0;
                min = prices[i + 1];
                i += 1;
            }
        }
        profit += max;
        return profit;
    }
}
// @lc code=end

