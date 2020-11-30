using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmTest.StringTests
{
    [TestClass]
    public class FirstUniqueCharTest
    {
        [TestMethod]
        [DataRow("loveleetcode")]
        public void FirstUniqueCharTestTrue(String s)
        {
            var a = new SampleCode.Strings.FirstUniqChar();
            var index = a.FirstUniqChar1(s);

        }
    }
}
