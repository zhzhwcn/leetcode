/*
 * @lc app=leetcode id=83 lang=csharp
 *
 * [83] Remove Duplicates from Sorted List
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
public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
        if(head == null) return head;
        var node = head;
        while (node.next != null)
        {
            if(node.next.val == node.val)
            {
                node.next = node.next.next;
            }
            else
            {
                node = node.next;
            }
        }
        return head;
    }
}
// @lc code=end

