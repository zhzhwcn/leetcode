/*
 * @lc app=leetcode id=141 lang=csharp
 *
 * [141] Linked List Cycle
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        var node1 = head;
        var node2 = head;
        while(node1 != null && node2 != null){
            if(node2.next == null) return false;
            node1 = node1.next;
            node2 = node2.next.next;
            if(node1 == node2) return true;
        }
        return false;
    }
}
// @lc code=end

