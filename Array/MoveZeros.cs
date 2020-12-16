using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    
    public class MoveZeros
    {
        public int[] nums = { 0, 1, 0 };
        public void MoveZerosTest()
        {
            int count = 0;
            if (nums == null || nums.Length == 1)
                return;

            for(int i = 0; i<nums.Length;i++)
            {
                if (i - count == nums.Length-1-count)
                    break;
                if(nums[i] == 0)
                {
                    count++;
                    for(int j = i+1; j<nums.Length; j++)
                    {
                        nums[j - 1] = nums[j];

                    }
                }
            }
            int l = nums.Length;
            for(int k = count; k>=1; k--)
            {
                nums[l-1] = 0;
                l--;
            }
        }
    }
}
