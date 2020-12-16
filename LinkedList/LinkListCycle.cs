using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleCode.LinkedList;
namespace SampleCode
{
    public class LinkListCycle
    {
        public ListNode MakeListCycle()
        {
            var ls = new SampleCode.LinkedList.LinkedList();

            var head = ls.Add(2);
           var first = ls.Add(6);
            ls.Add(16);
           var last = ls.Add(3);
            last.next = first;
            //PrintListCycle(head);
            return head;

        }

        public void PrintListCycle(ListNode head)
        {
            ListNode current = head;
            int count = 0; 
            while (current != null && count <= 10)
            {
                count++;
                Console.WriteLine(current.val);
                current = current.next;
            }
        }

        public bool HasCycle(ListNode head)
        {
            
            bool hasCycle = true;
            if (head == null)
                return false;
            var slow = head;
            var fast = head.next;

            while (slow != fast)
            {
                if (fast == null || fast.next == null)
                {
                    hasCycle = false;
                    break;
                }

                slow = slow.next;
                fast = fast.next.next;
            }

            return hasCycle;
        }
    }
}
