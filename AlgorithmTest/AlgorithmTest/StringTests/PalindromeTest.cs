using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleCode;


namespace AlgorithmTest
{
    [TestClass]
    public class Palindrometest
    {
        [TestMethod]
        [DataRow("wow")]
        [DataRow("A man, a plan, a canal: Panama")]
        public void Palindrome_True(string str)
        {
            var p = new Palindrome();
            var result = p.Palindrome1(str);

            Assert.IsTrue(result);
        }

        [TestMethod]
        [DataRow("papa")]
        [DataRow("NotPalindrome")]
        public void Palindrome_False(string str)
        {
            var p = new Palindrome();
            var result = p.Palindrome1(str);

            Assert.IsFalse(result);
        }

    }
}
