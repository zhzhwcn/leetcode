/*
 * @lc app=leetcode id=21 lang=csharp
 *
 * [21] Merge Two Sorted Lists
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution
{
    public ListNode MergeTwoLists(ListNode l1, ListNode l2)
    {
        if (l1 == null && l2 == null) return null;
        var newNode = new ListNode(0);
        if (l2 == null && l1 != null)
        {
            newNode.val = l1.val;
            newNode.next = MergeTwoLists(l1.next, l2);
        }
        else if ((l1 == null && l2 != null))
        {
            newNode.val = l2.val;
            newNode.next = MergeTwoLists(l1, l2.next);
        }
        else if (l1.val <= l2.val)
        {
            newNode.val = l1.val;
            newNode.next = MergeTwoLists(l1.next, l2);
        }
        else if (l1.val > l2.val)
        {
            newNode.val = l2.val;
            newNode.next = MergeTwoLists(l1, l2.next);
        }
        return newNode;
    }
}
// @lc code=end

