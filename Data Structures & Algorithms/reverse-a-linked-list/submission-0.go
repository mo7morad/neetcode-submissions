/**
 * Definition for singly-linked list.
 * type ListNode struct {
 *     Val  int
 *     Next *ListNode
 * }
 */

func reverseList(head *ListNode) *ListNode {
	if head == nil {
		return head
	}

	temp := head.Next
	head.Next = nil

	for temp != nil {
		nxt := temp
		temp = nxt.Next
		nxt.Next = head
		head = nxt
	}

	return head
}