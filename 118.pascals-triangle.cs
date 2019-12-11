/*
 * @lc app=leetcode id=118 lang=csharp
 *
 * [118] Pascal's Triangle
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        var list = new List<IList<int>>();
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
            list.Add(row);
            prevList = row;
        }
        return list;
    }
}
// @lc code=end

