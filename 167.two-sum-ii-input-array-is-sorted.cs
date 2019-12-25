/*
 * @lc app=leetcode id=167 lang=csharp
 *
 * [167] Two Sum II - Input array is sorted
 */

// @lc code=start
public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        
        for(var index1 = 0; index1 < numbers.Length; index1++)
        {
            for(var index2 = index1 + 1;index2 < numbers.Length; index2++)
            {
                var result = numbers[index1] + numbers[index2];
                if(result > target) break;
                if(result == target){
                    return new int[] {index1+1, index2+1};
                }
            }
        }
        return null;
    }
}
// @lc code=end

