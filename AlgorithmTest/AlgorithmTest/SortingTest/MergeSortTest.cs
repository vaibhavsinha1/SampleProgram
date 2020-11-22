using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmTest.SortingTest
{
    [TestClass]
    public class MergeSort
    {
        [TestMethod]
        [DataRow(new int[] {3, 4, 5, 2, 1, 8})]
        public void MergeSortTrue(int[] arr)
        {
            var sort = new SampleCode.MergeSort();
            sort.MergeSort1(arr);
            bool b = isInAscOrder(arr);
            Assert.IsTrue(b);


        }

        public bool isInAscOrder(int[] nums)
        {
            bool bIsInAscOrder = true;
            for (int i = 0; i < nums.Length - 1; i++)
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
