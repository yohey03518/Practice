using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sorting.Core;

namespace Sorting.Test
{
    [TestClass]
    public class HeapSortTest
    {

        [TestMethod]
        public void HeapSort_5_return5()
        {
            HeapSort heapSort = new HeapSort();
            int[] elements = new int[2] { 0, 5 };
            heapSort.Sort(elements, 1);
            Assert.AreEqual(5, elements[1]);
        }

        [TestMethod]
        public void HeapSort_35_return35()
        {
            HeapSort heapSort = new HeapSort();
            int[] elements = new int[3] { 0, 3, 5 };
            heapSort.Sort(elements, 2);
            Assert.AreEqual(3, elements[1]);
            Assert.AreEqual(5, elements[2]);
        }

        [TestMethod]
        public void HeapSort_53_return35()
        {
            HeapSort heapSort = new HeapSort();
            int[] elements = new int[3] { 0, 5, 3 };
            heapSort.Sort(elements, 2);
            Assert.AreEqual(3, elements[1]);
            Assert.AreEqual(5, elements[2]);
        }

        [TestMethod]
        public void HeapSort_426_return246()
        {
            HeapSort heapSort = new HeapSort();
            int[] elements = new int[4] { 0, 4, 2, 6 };
            heapSort.Sort(elements, 3);
            Assert.AreEqual(2, elements[1]);
            Assert.AreEqual(4, elements[2]);
            Assert.AreEqual(6, elements[3]);
        }

        [TestMethod]
        public void HeapSort_426973_return234679()
        {
            HeapSort heapSort = new HeapSort();
            int[] elements = new int[7] { 0,4, 2, 6, 9, 7, 3 };
            heapSort.Sort(elements, 6);
            Assert.AreEqual(2, elements[1]);
            Assert.AreEqual(3, elements[2]);
            Assert.AreEqual(4, elements[3]);
            Assert.AreEqual(6, elements[4]);
            Assert.AreEqual(7, elements[5]);
            Assert.AreEqual(9, elements[6]);
        }

        [TestMethod]
        public void HeapSort_123_return123()
        {
            HeapSort heapSort = new HeapSort();
            int[] elements = new int[4] { 0,1, 2, 3 };
            heapSort.Sort(elements, 3);
            Assert.AreEqual(1, elements[1]);
            Assert.AreEqual(2, elements[2]);
            Assert.AreEqual(3, elements[3]);
        }

        [TestMethod]
        public void HeapSort_321_return123()
        {
            HeapSort heapSort = new HeapSort();
            int[] elements = new int[4] { 0,3, 2, 1 };
            heapSort.Sort(elements, 3);
            Assert.AreEqual(1, elements[1]);
            Assert.AreEqual(2, elements[2]);
            Assert.AreEqual(3, elements[3]);
        }

        [TestMethod]
        public void HeapSort_1706359_return0135679()
        {
            HeapSort heapSort = new HeapSort();
            int[] elements = new int[8] { 0,1, 7, 0, 6, 3, 5, 9 };
            heapSort.Sort(elements, 7);
            Assert.AreEqual(0, elements[1]);
            Assert.AreEqual(1, elements[2]);
            Assert.AreEqual(3, elements[3]);
            Assert.AreEqual(5, elements[4]);
            Assert.AreEqual(6, elements[5]);
            Assert.AreEqual(7, elements[6]);
            Assert.AreEqual(9, elements[7]);
        }
    }
}
