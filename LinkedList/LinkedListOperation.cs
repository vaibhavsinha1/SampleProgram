using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode.LinkedList
{
    public class LinkedListOperation
    {
        public String InsertNode1()
        {

            var ls = new LinkedList();
            //ls.PrintAllNode();
            Console.ReadKey();

            var head = ls.Add(2);
            ls.Add(6);
            ls.Add(16);
            ls.Add(3);
            ls.PrintAllNode(head);

            return "Added";
        }



        public String DeleteNode1()
        {
            var ls = new LinkedList();
            var head = ls.Add(2);
            ls.Add(6);
            var n = ls.Add(16);
            ls.Add(3);
            ls.PrintAllNode(head);
            Console.ReadKey();

            ls.DeleteNode(n);

            ls.PrintAllNode(head);
            Console.ReadKey();

            return "Deleted";
        }

        public String RemoveNthFromEnd1()
        {
            var ls = new LinkedList();
            var head = ls.Add(2);
            ls.Add(6);
            //ls.Add(16);
            //ls.Add(3);
            //ls.Add(2);
            //ls.Add(8);
            ls.PrintAllNode(head);
            Console.ReadKey();

            head = ls.RemoveNthFromEnd(head,2);

            ls.PrintAllNode(head);
            Console.ReadKey();

            return "Removed";
        }

        public String Reverse()
        {
            var ls = new LinkedList();
            var head = ls.Add(2);
            ls.Add(6);
            ls.Add(16);
            ls.Add(3);
            ls.Add(2);
            ls.Add(8);
            ls.PrintAllNode(head);
            Console.ReadKey();

            head = ls.Reverse(head);

            ls.PrintAllNode(head);
            Console.ReadKey();

            return "Reversed";
        }


    }
}
