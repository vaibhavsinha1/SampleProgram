using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    //https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/549/
    public class SingleNumber
    {
        int[] nums = { 1,1, 4, 4, 2, 3, 3};
        
        public int IsSingleNumber1()
        {
            Array.Sort(nums);
            int a, b;
            for(int i=0; i<nums.Length; i=i+2)
            {
                a = nums[i];
                if (i + 1 == nums.Length)
                    return a;
                else
                b = nums[i + 1];
                if (a != b)
                    return a;
            }

            return 0;

        }
    }
}
