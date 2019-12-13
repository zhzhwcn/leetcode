/*
 * @lc app=leetcode id=160 lang=csharp
 *
 * [160] Intersection of Two Linked Lists
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
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        if(headA == null || headB == null) return null;
        var nodeA = headA;
        while(nodeA != null){
            var nodeB = headB;
            while(nodeB != null){
                if(nodeB == nodeA) return nodeA;
                nodeB = nodeB.next;
            }
            nodeA = nodeA.next;
        }
        return null;
    }
}
// @lc code=end

