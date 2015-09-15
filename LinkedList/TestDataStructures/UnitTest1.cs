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
            ll.AddFirst(7);
            ll.AddFirst(9);
            ll.AddFirst(9);
            ll.AddFirst(9);
            ll.AddFirst(9);
            ll.AddFirst(9);
            ll.AddFirst(9);
            ll.AddFirst(9);
            ll.AddFirst(8);
            ll.AddFirst(9);
            ll.AddFirst(9);
            ll.AddFirst(9);
            ll.AddFirst(9);
            Assert.AreEqual(true, ll.Contains(8));
            Assert.AreEqual(false, ll.Contains(6));
        }

        [TestMethod]
        public void TestReverse()
        {
            LinkedList<int> ll = new LinkedList<int>();
            ll.AddFirst(9);
            ll.AddFirst(8);
            ll.AddFirst(7);
            ll.AddFirst(6);
            ll.AddFirst(5);
            ll.AddFirst(4);
            ll.AddFirst(3);
            ll.AddFirst(2);
            ll.AddFirst(1);     

            ll.Reverse();

            int[] myAnswer = ll.ToArray();

            int[] answer = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], myAnswer[i]);
            }

            LinkedList<int> l2 = new LinkedList<int>();
            l2.AddFirst(9);
            l2.AddFirst(8);
            l2.AddFirst(7);
            l2.AddFirst(6);
            l2.AddFirst(5);
            l2.AddFirst(4);
            l2.AddFirst(3);
            l2.AddFirst(2);
            l2.AddFirst(1);

            l2.ReverseRecursive();

            int[] myRecursiveAnswer = l2.ToArray();

            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], myRecursiveAnswer[i]);
            }
        }
    }
}
