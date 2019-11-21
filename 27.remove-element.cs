/*
 * @lc app=leetcode id=27 lang=csharp
 *
 * [27] Remove Element
 */

// @lc code=start
using System.Linq;
public class Solution {
    public int RemoveElement(int[] nums, int val) {
        var list = nums.ToList();
        list.RemoveAll(x => x == val);
        Array.Copy(list.ToArray(), nums, list.Count);
        return list.Count;
    }
}
// @lc code=end

