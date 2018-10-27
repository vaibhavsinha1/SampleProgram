using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    
    public class SearchForRange
    {
        int[] nums = { 1};
        int target = 1;
        public int[] SearchForRange1()
        {
            int[] a = { -1, -1 };
            int fill = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    a[fill] = i;
                    if(fill == 0)
                        fill++;
                }
                
            }
            if (a[0] != -1 && a[1] == -1)
                a[1] = a[0];

            return a;
        }
    }
}
