using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    public class RotateArray
    {
        int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
        int k = 3;
        public int[] RotateArray1()
        {
            int n;
            for(int i =0;i< k; i++)
            {
                n = nums[nums.Length-1];
                for(int j=nums.Length-1;j>0;j--)
                {
                    nums[j] = nums[j - 1];
                }
                nums[0] = n;

            }
            return nums;
        }
    }
}
