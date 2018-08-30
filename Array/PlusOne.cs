using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    public class PlusOne
    {
        int[] digits = { 1, 3, 2, 3 };
        public int[] PlusOne1()
        {
            int n = digits.Length;
            for (int i = n - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }

                digits[i] = 0;
            }

            int[] newNumber = new int[n + 1];
            newNumber[0] = 1;

            return newNumber;

        }
    }
}
