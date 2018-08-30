using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    public class TwoSum
    {
        int[] sum = { 3, 4, 5, 2 };
        int target = 5;
        public int[] TwoSum1()
        {
            int[] t = { 0, 0 };
            bool found = false;
            for (int i = 0; i < sum.Length; i++)
            {
                for (int j = i+1; j < sum.Length; j++)
                {
                    if(sum[i] + sum[j] == target)
                    {
                        t[0] = i;
                        t[1] = j;
                        found = true;
                        break;
                    }
                }
                if (found)
                    break;
            }

            return t;

        }
    }
}
