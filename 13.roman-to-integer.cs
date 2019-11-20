/*
 * @lc app=leetcode id=13 lang=csharp
 *
 * [13] Roman to Integer
 *
 * https://leetcode.com/problems/roman-to-integer/description/
 *
 * algorithms
 * Easy (53.74%)
 * Likes:    1554
 * Dislikes: 2990
 * Total Accepted:    527.5K
 * Total Submissions: 981.4K
 * Testcase Example:  '"III"'
 *
 * Roman numerals are represented by seven different symbols: I, V, X, L, C, D
 * and M.
 * 
 * 
 * Symbol       Value
 * I             1
 * V             5
 * X             10
 * L             50
 * C             100
 * D             500
 * M             1000
 * 
 * For example, two is written as II in Roman numeral, just two one's added
 * together. Twelve is written as, XII, which is simply X + II. The number
 * twenty seven is written as XXVII, which is XX + V + II.
 * 
 * Roman numerals are usually written largest to smallest from left to right.
 * However, the numeral for four is not IIII. Instead, the number four is
 * written as IV. Because the one is before the five we subtract it making
 * four. The same principle applies to the number nine, which is written as IX.
 * There are six instances where subtraction is used:
 * 
 * 
 * I can be placed before V (5) and X (10) to make 4 and 9. 
 * X can be placed before L (50) and C (100) to make 40 and 90. 
 * C can be placed before D (500) and M (1000) to make 400 and 900.
 * 
 * 
 * Given a roman numeral, convert it to an integer. Input is guaranteed to be
 * within the range from 1 to 3999.
 * 
 * Example 1:
 * 
 * 
 * Input: "III"
 * Output: 3
 * 
 * Example 2:
 * 
 * 
 * Input: "IV"
 * Output: 4
 * 
 * Example 3:
 * 
 * 
 * Input: "IX"
 * Output: 9
 * 
 * Example 4:
 * 
 * 
 * Input: "LVIII"
 * Output: 58
 * Explanation: L = 50, V= 5, III = 3.
 * 
 * 
 * Example 5:
 * 
 * 
 * Input: "MCMXCIV"
 * Output: 1994
 * Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
 * 
 */

// @lc code=start
public class Solution {
    public int RomanToInt(string s) {
        var arr = s.ToCharArray();
            var result = 0;
            for(var i = 0; i < arr.Length;)
            {
                var next = i + 1;
                switch (arr[i])
                {
                    case 'I':
                        if(next < arr.Length)
                        {
                            if (arr[next] == 'V')
                            {
                                result += 4;
                                i += 2;
                            }
                            else if (arr[next] == 'X')
                            {
                                result += 9;
                                i += 2;
                            }
                            else
                            {
                                result += 1;
                                i += 1;
                            }
                        }
                        else
                        {
                            result += 1;
                            i += 1;
                        }
                        break;
                    case 'V':
                        result += 5;
                        i += 1;
                        break;
                    case 'X':
                        if (next < arr.Length)
                        {
                            if (arr[next] == 'L')
                            {
                                result += 40;
                                i += 2;
                            }
                            else if (arr[next] == 'C')
                            {
                                result += 90;
                                i += 2;
                            }
                            else
                            {
                                result += 10;
                                i += 1;
                            }
                        }
                        else
                        {
                            result += 10;
                            i += 1;
                        }
                        break;
                    case 'L':
                        result += 50;
                        i += 1;
                        break;
                    case 'C':
                        if (next < arr.Length)
                        {
                            if (arr[next] == 'D')
                            {
                                result += 400;
                                i += 2;
                            }
                            else if (arr[next] == 'M')
                            {
                                result += 900;
                                i += 2;
                            }
                            else
                            {
                                result += 100;
                                i += 1;
                            }
                        }
                        else
                        {
                            result += 100;
                            i += 1;
                        }
                        break;
                    case 'D':
                        result += 500;
                        i += 1;
                        break;
                    case 'M':
                        result += 1000;
                        i += 1;
                        break;
                    default:
                        throw new Exception("out of range");
                }
            }

            return result;
    }
}
// @lc code=end

