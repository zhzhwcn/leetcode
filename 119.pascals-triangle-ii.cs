/*
 * @lc app=leetcode id=119 lang=csharp
 *
 * [119] Pascal's Triangle II
 */

// @lc code=start
public class Solution {
    public IList<int> GetRow(int rowIndex) {
        var numRows = rowIndex + 1;
        List<int> prevList = new List<int>();
        for(var i = 1; i <= numRows; i++)
        {
            var row = new List<int>();
            for(var j = 0; j < i; j++)
            {
                if(j == 0 || j == i-1)
                {
                    row.Add(1);
                    continue;
                }
                row.Add(prevList[j] + prevList[j-1]);
            }
            prevList = row;
        }
        return prevList;
    }
}
// @lc code=end

