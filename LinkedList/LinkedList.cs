using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode.LinkedList
{
    public class ListNode
    {
        public ListNode next { get; set; }
        public int val { get; set; }

        public ListNode(int x)
        {
            val = x;
        }
    }
    public class LinkedList
    {
        private ListNode Head { get; set; }

        public void PrintAllNode(ListNode head)
        {
            ListNode current = head;
            while(current != null)
            {
                Console.WriteLine(current.val);
                current = current.next;
            }
        }

        public ListNode Add(int data)
        {
            if (Head == null)
            {
                Head = new ListNode(data)
                {
                    next = null
                };

                return Head;
            }
            else
            {
                var n = new ListNode(data);
                ListNode current = Head;
                while(current.next != null)
                {
                    current = current.next;
                }
                current.next = n;

                return n;
            }
        }

        public void DeleteNode(ListNode node)
        {
            node.val = node.next.val;
            node.next = node.next.next;
        }

        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            int count = 1;
            ListNode current = head;
            while (current.next != null)
            {
                count++;
                current = current.next;
            }
            if (count == 1 && n == 1)
                return null;
            if (n > count)
                return head;

            int loop = 1;
            current = head;
            while (loop < count - n)
            {
                loop++;
                current = current.next;
            }
            if (count == n)
            {
                head = head.next;
            }
            else if (current.next.next == null)
            {
                current.next = null;
            }
            else
            {
                current.next = current.next.next;
            }
            return head;
        }

        
    }
}
