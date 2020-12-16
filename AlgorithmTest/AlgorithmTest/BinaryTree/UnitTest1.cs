using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AlgorithmTest.BinaryTree
{
    [TestClass]
    public class BinaryTreeTest1
    {
        [TestMethod]
        public void BinaryTreeTest_1()
        {
            var s = new SampleCode.BinaryTreeTest1.BinaryTreeTest();
            var tree = s.CreateTree();
            s.InorderTraversal(tree.Root);
        }
    }
}
