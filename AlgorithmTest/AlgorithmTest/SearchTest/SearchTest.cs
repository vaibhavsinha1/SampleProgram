using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmTest.SearchTest
{
    [TestClass]
    public class SearchTest
    {
        [TestMethod]
        [DataRow(new int[] { 3,5,7,9,10})]
        public void SearchTestTrue(int[] arr)
        {
            var search = new SampleCode.BinarySearch();
            var x =search.BinarySearch1(arr, 10);
            Assert.IsTrue(x == 2);

        }
        [TestMethod]
        [DataRow(new int[] {3})]
        public void SearchTestSingle(int[] arr)
        {
            var search = new SampleCode.BinarySearch();
            var x = search.BinarySearch1(arr, 3);
            Assert.IsTrue(x == 0);

        }

    }
}
