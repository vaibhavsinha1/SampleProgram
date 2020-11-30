using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    //https://leetcode.com/explore/interview/card/microsoft/30/array-and-strings/213/
    public class ReverseWordStringII
    {
        private char[] s = { 'H', 'e', 'l', 'l', 'o',' ', 'h', 'o', 'w' };
        //private char[] s = { 'h', 'o', 'w' };

        public char[] ReverseWordStringII1()
        {
            Reverse(ref s, 0, s.Length-1);
            Console.WriteLine(s);
            Console.Read();
            ReverseWord(ref s);
            return s;
        }

        public void Reverse(ref char[] s, int left, int right)
        {
            char temp;
            //int count = 0;
            while (left < right)
            {
                temp = s[left];
                s[left++] = s[right];
                s[right--] = temp;
            }
        
        }

        public void ReverseWord(ref char[] s)
        {
            int start = 0;
            int end = 0;
            int n = s.Length;
            while(start <n)
            {
                while (end < n && s[end] != ' ') ++end;
                Reverse(ref s, start, end-1);
                //Reverse(ref s, end - 1, start / 2 == 0 ? 1 : start / 2);
                start = end + 1;
                ++end;
            }

        }

    }
}
