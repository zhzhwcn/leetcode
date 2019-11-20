using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var node1 = new ListNode(4);
            var node2 = new ListNode(3);
            node2.next = node1;
            var node3 = new ListNode(1);
            node3.next = node2;
            var node4 = new ListNode(4);
            var node5 = new ListNode(2);
            node5.next = node4;
            var node6 = new ListNode(1);
            node6.next = node5;
            var r = "{[]}}";
            Console.WriteLine(new Solution().MergeTwoLists(node3, node6));
        }
    }

    public class Solution
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null && l2 == null) return null;
            var newNode = new ListNode(0);
            if(l2 == null && l1 != null)
            {
                newNode.val = l1.val;
                newNode.next = MergeTwoLists(l1.next, l2);
            }
            else if((l1 == null && l2 != null))
            {
                newNode.val = l2.val;
                newNode.next = MergeTwoLists(l1, l2.next);
            }
            else if(l1.val <= l2.val)
            {
                newNode.val = l1.val;
                newNode.next = MergeTwoLists(l1.next, l2);
            }
            else if(l1.val > l2.val)
            {
                newNode.val = l2.val;
                newNode.next = MergeTwoLists(l1, l2.next);
            }
            return newNode;
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
