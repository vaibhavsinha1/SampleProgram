using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmTest.SortingTest
{
    [TestClass]
    public class SortColorTest
    {
        [TestMethod]
        [DataRow(new int[] { 0, 2, 1 })]
        public void SortColor1(int[] nums)
        {
            var p = new SampleCode.SortColors();
            bool b = isInAscOrder(nums);
             p.SortColors1(nums);
            b = isInAscOrder(nums);
            Assert.IsTrue(b);
        }

        public bool isInAscOrder(int[] nums)
        {
            bool bIsInAscOrder = true;
            for (int i =0; i<nums.Length-1; i++)
            {
                if (nums[i] > nums[i + 1])
                {
                    bIsInAscOrder = false;
                    break;
                }
            }

            return bIsInAscOrder;
        }
    }
}
