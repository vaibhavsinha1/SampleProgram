using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    //https://leetcode.com/explore/interview/card/top-interview-questions-medium/110/sorting-and-searching/798/
    public class SortColors
    {

        public void SortColors1(int[] nums)
        {
            int current, P0, P2, temp;

            P2 = nums.Length - 1;
            current = P0 = 0;

            while (current <= P2)
            {
                if (nums[current] == 2)
                {
                    temp = nums[current];
                    nums[current] = nums[P2];
                    nums[P2] = temp;
                    P2--;
                }
                else if (nums[current] == 0)
                {
                    temp = nums[P0];
                    nums[P0] = nums[current];
                    P0++;
                    nums[current] = temp;
                    current++;
                }
                else 
                    current++;

            }

        }

        public void swap(int[] nums)
        {

        }
    }
}
