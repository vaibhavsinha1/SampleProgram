using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleCode;

namespace AlgorithmTest.StringTests
{
    [TestClass]
    public class PatentheseTest
    {
        [TestMethod]
        [DataRow("([])")]
        [DataRow("({[]})")]
        public void ParantheseTest_True(String s)
        {
            var p = new ValidParentheses();
            bool b = p.IsValidParantheses(s);
            Assert.IsTrue(b);  
        }

        [TestMethod]
        [DataRow("([]{{)")]
        public void ParantheseTest_False(String s)
        {
            var p = new ValidParentheses();
            bool b = p.IsValidParantheses(s);
            Assert.IsFalse(b);
        }
    }
}
