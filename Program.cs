using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleCode.Strings;
using SampleCode.LinkedList;
namespace SampleCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //var c = new ContainDuplicates();
            //Console.WriteLine(c.IsDuplicates4());
            //Console.Read();

            //var c = new SingleNumber();
            //Console.WriteLine(c.IsSingleNumber1());
            //Console.Read();

            //var c = new PlusOne();
            //var a = c.PlusOne1();
            //Console.WriteLine(a);
            //Console.Read();

            //var c = new TwoSum();
            //var a = c.TwoSum1();
            //Console.WriteLine(a);
            //Console.Read();

            //var c = new RemoveDuplicates();
            //var a = c.RemoveDuplicates1();
            //Console.WriteLine(a);
            //Console.Read();

            //var c = new RotateArray();
            //var a = c.RotateArray1();
            //Console.WriteLine(a);
            //Console.Read();

            //var c = new StringReverse();
            //var a = c.StringReverse1();
            //Console.WriteLine(a);
            //Console.Read();

            //var c = new Fibannoci();
            //var a = c.Fibannoci2(9);
            //Console.WriteLine(a);
            //Console.Read();

            //var c = new FirstUniqChar();
            //var a = c.FirstUniqChar1();
            //Console.WriteLine(a);
            //Console.Read();

            //var c = new Str();
            //var a = c.StrStr1();
            //Console.WriteLine(a);
            //Console.Read();

            //var c = new Palindrome();
            //var a = c.Palindrome2();
            //Console.WriteLine(a);
            //Console.Read();

            //var c = new LinkedListOperation();
            //var a = c.InsertNode1();
            //Console.WriteLine(a);
            //Console.Read();

            //var c = new LinkedListOperation();
            //var a = c.DeleteNode1();
            //Console.WriteLine(a);
            //Console.Read();

            //var c = new LinkedListOperation();
            //var a = c.RemoveNthFromEnd1();
            //Console.WriteLine(a);
            //Console.Read();

            //var c = new LinkedListOperation();
            //var a = c.Reverse();
            //Console.WriteLine(a);
            //Console.Read();

            //var c = new ProductExceptSelf();
            //var a = c.ProductExceptSelf1();
            //Console.WriteLine(a);
            //Console.Read();

            //var c = new Sum3();
            //var a = c.Sum31();
            //Console.WriteLine(a);
            //Console.Read();

            //var c = new SetMatrixZero();
            //c.SetMatrixZero1();
            ////Console.WriteLine(a);
            //Console.Read();


            //var c = new Angrams();
            //var a = c.angrams1();
            //Console.WriteLine(a);
            //Console.Read();

            //var c = new LongestSubString();
            //var a = c.LongestSubString1();
            //Console.WriteLine(a);
            //Console.Read();

            var b =new BinaryTree();
            b.Insert(3);
            b.Insert(4);
            b.Insert(7);
            b.Insert(5);
            b.Insert(2);
            b.Insert(1);
            //b.Insert(10);
            //b.Insert(12);


            b.InOrderTraversal(b.root);
            Console.Read();
            b.PreOrderTraversal(b.root);
            Console.Read();

            b.PostOrderTraversal(b.root);
            Console.Read();

            //int a = 2;
            //bool primenumberLoop = true;
            //bool isPrimeFound = false;
            //for (int i = 1; i<=10001; i++)
            //{
            //    primenumberLoop = true;
            //    while(primenumberLoop)
            //    {
            //        isPrimeFound = IsPrime(a);
            //        if (isPrimeFound)
            //        {
            //            primenumberLoop = false;
            //            a++;
            //        }
            //        else
            //        {
            //            a++;
            //        }
            //    }
            //}
            //a--;
        }

        private static bool IsPrime(int a)
        {
            bool isPrime = true;
            if (a != 2)
            {
                for (int s = 2; s < a; s++)
                {
                    if (a % s == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            return isPrime;
        }
    }
}
