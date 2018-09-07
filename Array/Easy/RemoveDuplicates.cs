using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{

    public class RemoveDuplicates
    {
        int[] nums = { };

        public int RemoveDuplicates1()
        {
            int l = 0;
            int highest = 0;
            if (nums.Length > 0)
                highest = nums[nums.Length - 1] + 1;
            int i = 0;
            int j = 0;
            while (i < nums.Length)
            {
                j = i + 1;
                if (j < nums.Length)
                {
                    while (nums[i] == nums[j])
                    {
                        nums[j] = highest;
                        j++;
                        if (j >= nums.Length)
                        {
                            i = j;
                            break;
                        }
                    }
                    i = j;
                }
                else
                    i = j;

                l++;

            }
            Array.Sort(nums);
            return l;
        }

    }
}
