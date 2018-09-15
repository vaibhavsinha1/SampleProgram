using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    public class Sum3
    {
        //int[] nums = { -1, 0, 1, 2, -1, -4 };
        int[] nums = { 8, -15, -2, -13, 8, 5, 6, -3, -9, 3, 6, -6, 8, 14, -9, -8, -9, -6, -14, 5, -7, 3, -10, -14, -12, -11, 12, -15, -1, 12, 8, -8, 12, 13, -13, -3, -5, 0, 10, 2, -11, -7, 3, 4, -8, 9, 3, -10, 11, 5, 10, 11, -7, 7, 12, -12, 3, 1, 11, 9, -9, -4, 9, -12, -6, 11, -7, 4, -4, -12, 13, -8, -12, 2, 3, -13, -12, -8, 14, 14, 12, 9, 10, 12, -6, -1, 8, 4, 8, 4, -1, 14, -15, -7, 9, -14, 11, 9, 5, 14 };

        public IList<IList<int>> Sum31()
        {
            var isum = new List<IList<int>>();
            for(int i=0; i<nums.Length-2; i++)
            {
                for (int j = i+1; j<nums.Length-1; j++)
                {
                    for(int k=j+1; k<nums.Length;k++)
                    {
                        if (nums[i] + nums[j] + nums[k] == 0)
                        {
                            isum.Add(new List<int>() { nums[i], nums[j], nums[k] });
                        }
                    }
                }
            }

            return isum;
        }

    }
}
