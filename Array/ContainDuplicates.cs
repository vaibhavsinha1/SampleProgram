using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    public class ContainDuplicates
    {
        int[] nums = { 1, 2, 3, 4,5,4 };
        public bool IsDuplicates1()
        {
            //bool isDuplicate = false;
           
            for(int i=0; i<nums.Length; i++)
            {
                for (int s=i+1;s<nums.Length; s++)
                {
                    Console.WriteLine(nums[i]);
                    if (nums[i] == nums[s])
                        return true;
                }
            }

            return false;
        }

        public bool IsDuplicates2()
        {
            for (int i = 0; i < nums.Length; ++i)
            {
                for (int j = 0; j < i; ++j)
                {
                    if (nums[j] == nums[i]) return true;
                }
            }
            return false;
        }

        public bool IsDuplicates3()
        {
            Array.Sort(nums);
            for (int i = 0; i < nums.Length-1; i++)
            {
                if (nums[i] == nums[i + 1]) return true;
            }
            return false;
        }

        public bool IsDuplicates4()
        {
            HashSet<int> hashSet = new HashSet<int>(nums);
            if (nums.Length == hashSet.Count)
                return false;
            else
                return true;
        }
    }
}
