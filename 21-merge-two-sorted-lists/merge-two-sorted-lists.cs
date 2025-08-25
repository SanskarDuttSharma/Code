/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode p1 = new ListNode();
        ListNode p2 = new ListNode();

        p1 = list1;
        p2 = list2;

        if(p1 == null){
            return list2;
        }
        if(p2 == null){
            return list1;
        }

        ListNode head = null;
        ListNode current = null;

        while(p1 != null && p2 != null){
            if(p1.val > p2.val){
                if(head == null){
                    head = p2;
                    current = head;
                }
                else{
                    current.next = p2;
                    current = p2;
                }
                p2 = p2.next;
            }
            else{
                if(head == null){
                    head = p1;
                    current = head;

                }
                else{
                    current.next = p1;
                    current = p1;
                }
                p1 = p1.next;
            }
        }

        if(p1 != null){
            current.next = p1;
        }
        if(p2 != null){
            current.next = p2;
        }
        
        return head;
    }
}