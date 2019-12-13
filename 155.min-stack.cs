/*
 * @lc app=leetcode id=155 lang=csharp
 *
 * [155] Min Stack
 */

// @lc code=start
using System.Collections.Generic;
public class MinStack {

    /** initialize your data structure here. */
    private Stack<int> _stack;
    public MinStack()
    {
        _stack = new Stack<int>();
    }

    public void Push(int x)
    {
        _stack.Push(x);
    }

    public void Pop()
    {
        _stack.Pop();
    }

    public int Top()
    {
        return _stack.FirstOrDefault();
    }

    public int GetMin()
    {
        return _stack.Min();
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(x);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */
// @lc code=end

