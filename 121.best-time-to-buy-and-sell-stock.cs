/*
 * @lc app=leetcode id=121 lang=csharp
 *
 * [121] Best Time to Buy and Sell Stock
 */

// @lc code=start
public class Solution {
    public int MaxProfit(int[] prices) {
        var profit = 0;
        for(var i = 0; i < prices.Length - 1; i++){
            for(var j = i + 1; j < prices.Length; j++) {
                if(prices[j] > prices[i] && prices[j] - prices[i] > profit){
                    profit = prices[j] - prices[i];
                }
            }
        }
        return profit;
    }
}
// @lc code=end

