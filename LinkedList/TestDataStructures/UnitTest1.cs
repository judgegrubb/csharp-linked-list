using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedList;

namespace TestDataStructures
{
    [TestClass]
    public class TestDS
    {
        [TestMethod]
        public void TestLinkedListAddFirstAndGetFirst()
        {
            LinkedList<int> ll = new LinkedList<int>();
            ll.AddFirst(5);
            Assert.AreEqual(5, ll.GetFirst());
        }

        [TestMethod]
        public void TestContains()
        {
            LinkedList<int> ll = new LinkedList<int>();
            ll.AddFirst(5);
            ll.AddLast(7);
            ll.AddLast(9);
            ll.AddLast(9);
            ll.AddLast(9);
            ll.AddLast(9);
            ll.AddLast(9);
            ll.AddLast(9);
            ll.AddLast(9);
            ll.AddLast(8);
            ll.AddLast(9);
            ll.AddLast(9);
            ll.AddLast(9);
            ll.AddLast(9);
            Assert.AreEqual(true, ll.Contains(8));
            Assert.AreEqual(false, ll.Contains(6));
        }
    }
}
