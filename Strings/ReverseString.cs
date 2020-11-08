using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    public class ReverseString
    {
        
        //private char[] input = { 'h', 'e', 'l', 'l', 'o' };
        private char[] input = { 'H', 'a', 'n', 'n', 'a', 'h' };

        public char[] ReverseString1()
        {
            char start;
            int count = 0;
            for (int i = input.Length - 1; i >= input.Length / 2; i--)
            {
                start = input[count];
                input[count] = input[i];
                input[i] = start;

                count++;
            }

            return input;
        }

    }
}
