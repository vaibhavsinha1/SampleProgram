using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AlgorithmTest.StringTests
{
    [TestClass]
    public class GroupAngramTest
    {
        [TestMethod]
        //[DataRow(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" })]
        //[DataRow(new string[] { "eat", "tan" })]
        [DataRow(new string[] { "", "b" })]
        public void GroupAngram_True(string[] strs)
        {
            var c = new SampleCode.GroupAngrams();
            c.GroupAngrams1(strs);
        }
    }
}
