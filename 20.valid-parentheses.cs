/*
 * @lc app=leetcode id=20 lang=csharp
 *
 * [20] Valid Parentheses
 */

// @lc code=start
public class Solution
{
    public bool IsValid(string s)
    {
        if (string.IsNullOrEmpty(s)) return true;
        var arr = s.ToCharArray();
        var pair = new[] { '(', '[', '{' };
        var pairClose = new[] { ')', ']', '}' };
        var pairStack = new Stack<char>();
        char? currentChar = null;
        for (int i = 0; i < arr.Length; i++)
        {
            var index = Array.IndexOf(pair, arr[i]);
            if (index != -1)
            {
                if (currentChar != null)
                {
                    pairStack.Push(currentChar.Value);
                }

                currentChar = arr[i];
            }
            else
            {
                index = Array.IndexOf(pairClose, arr[i]);
                if (index != -1)
                {
                    if (currentChar == null) return false;
                    var check = Array.IndexOf(pair, currentChar);
                    if (check != index)
                    {
                        return false;
                    }
                    else
                    {
                        if (pairStack.Count == 0)
                        {
                            currentChar = null;
                        }
                        else
                        {
                            currentChar = pairStack.Pop();
                        }
                    }
                }
                else
                {
                    return false;
                }
            }
        }
        if (currentChar != null || pairStack.Count > 0)
        {
            return false;
        }
        return true;
    }
}
// @lc code=end

