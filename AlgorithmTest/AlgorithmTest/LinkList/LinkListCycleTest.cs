using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AlgorithmTest.LinkList
{
    [TestClass]
    public class LinkListCycleTest
    {
        [TestMethod]
        public void LinkListCycleTest_hasCycle1()
        {
            var ls = new SampleCode.LinkedList.LinkedList();
            var head = ls.Add(2);
            var first = ls.Add(6);
            ls.Add(16);
            var last = ls.Add(3);
            last.next = first;

            var listCycle = new SampleCode.LinkListCycle();
            var hasCycle = listCycle.HasCycle(head);
            Assert.IsTrue(hasCycle);

        }
        [TestMethod]
        public void LinkListCycleTest_hasNoCycle1()
        {
            var ls = new SampleCode.LinkedList.LinkedList();
            var head = ls.Add(2);
            var first = ls.Add(6);
            ls.Add(16);
            var last = ls.Add(3);
            //last.next = first;

            var listCycle = new SampleCode.LinkListCycle();
            var hasCycle = listCycle.HasCycle(head);
            Assert.IsFalse(hasCycle);

        }
    }
}
