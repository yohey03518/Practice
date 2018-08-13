using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sorting.Core;

namespace Sorting.Test
{
    [TestClass]
    public class BubbleSortTest
    {

        [TestMethod]
        public void BubbleSort_5_return5()
        {
            BubbleSort bubbleSort = new BubbleSort();
            int[] elements = new int[1] { 5 };
            bubbleSort.Sort(elements, 1);
            Assert.AreEqual(5, elements[0]);
        }

        [TestMethod]
        public void BubbleSort_35_return35()
        {
            BubbleSort bubbleSort = new BubbleSort();
            int[] elements = new int[2] { 3, 5 };
            bubbleSort.Sort(elements, 2);
            Assert.AreEqual(3, elements[0]);
            Assert.AreEqual(5, elements[1]);
        }

        [TestMethod]
        public void BubbleSort_53_return35()
        {
            BubbleSort bubbleSort = new BubbleSort();
            int[] elements = new int[2] { 5, 3 };
            bubbleSort.Sort(elements, 2);
            Assert.AreEqual(3, elements[0]);
            Assert.AreEqual(5, elements[1]);
        }

        [TestMethod]
        public void BubbleSort_426_return246()
        {
            BubbleSort bubbleSort = new BubbleSort();
            int[] elements = new int[3] { 4, 2, 6 };
            bubbleSort.Sort(elements, 3);
            Assert.AreEqual(2, elements[0]);
            Assert.AreEqual(4, elements[1]);
            Assert.AreEqual(6, elements[2]);
        }

        [TestMethod]
        public void BubbleSort_426973_return234679()
        {
            BubbleSort bubbleSort = new BubbleSort();
            int[] elements = new int[6] { 4, 2, 6, 9, 7, 3 };
            bubbleSort.Sort(elements, 6);
            Assert.AreEqual(2, elements[0]);
            Assert.AreEqual(3, elements[1]);
            Assert.AreEqual(4, elements[2]);
            Assert.AreEqual(6, elements[3]);
            Assert.AreEqual(7, elements[4]);
            Assert.AreEqual(9, elements[5]);
        }

        [TestMethod]
        public void BubbleSort_123_return123()
        {
            BubbleSort bubbleSort = new BubbleSort();
            int[] elements = new int[4] { 0,1, 2, 3 };
            bubbleSort.Sort(elements, 3);
            Assert.AreEqual(1, elements[1]);
            Assert.AreEqual(2, elements[2]);
            Assert.AreEqual(3, elements[3]);
        }

        [TestMethod]
        public void BubbleSort_321_return123()
        {
            BubbleSort bubbleSort = new BubbleSort();
            int[] elements = new int[3] { 3, 2, 1 };
            bubbleSort.Sort(elements, 3);
            Assert.AreEqual(1, elements[0]);
            Assert.AreEqual(2, elements[1]);
            Assert.AreEqual(3, elements[2]);
        }

        [TestMethod]
        public void BubbleSort_1706359_return0135679()
        {
            BubbleSort bubbleSort = new BubbleSort();
            int[] elements = new int[7] { 1, 7, 0, 6, 3, 5, 9 };
            bubbleSort.Sort(elements, 7);
            Assert.AreEqual(0, elements[0]);
            Assert.AreEqual(1, elements[1]);
            Assert.AreEqual(3, elements[2]);
            Assert.AreEqual(5, elements[3]);
            Assert.AreEqual(6, elements[4]);
            Assert.AreEqual(7, elements[5]);
            Assert.AreEqual(9, elements[6]);
        }
    }
}
