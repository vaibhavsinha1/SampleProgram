using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AlgorithmTest.StringTests
{
    [TestClass]
    public class LongestCommonWordTest
    {
        [TestMethod]
        //[DataRow(new string[] { "Hello", "Sample1", "Sample2", "Sample3", "Samplex", "Sampley", "Samplez" })]
        [DataRow(new string[] { "Hello1", "Samplen", "Sample2", "Sample3", "Samplex", "Samplex", "Sampley" })]
        public void LongestCommonWordTest_True()
        {
            var c = new SampleCode.LongestCommonWords();
            c.LongestCommonWords1();

        }
    }
}
