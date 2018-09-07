using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
   public  class ProductExceptSelf
    {
        int[] nums = { 1, 2, 3, 4 };
        public int[] ProductExceptSelf1()
        {
            int[] p= new int[nums.Length];
            int count = 0;
            
            while (count < nums.Length)
            {
                p[count] = 1;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (i == count)
                        continue;
                    p[count] = p[count] * nums[i];
                }
                count++;

            }
            return p;
        }
    }
}
