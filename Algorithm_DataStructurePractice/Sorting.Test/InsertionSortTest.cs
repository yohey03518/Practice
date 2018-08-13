using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sorting.Core;

namespace Sorting.Test
{
    [TestClass]
    public class InsertionSortTest
    {
        [TestMethod]
        public void InsertionSort_123_return123()
        {
            InsertionSort insertionSort = new InsertionSort();
            int[] elements = new int[4] { 1, 2, 3, -1 };
            insertionSort.Sort(elements, 3);
            Assert.AreEqual(1, elements[0]);
            Assert.AreEqual(2, elements[1]);
            Assert.AreEqual(3, elements[2]);
            Console.Write(insertionSort.LastMovingCount);
        }

        [TestMethod]
        public void InsertionSort_321_return123()
        {
            InsertionSort insertionSort = new InsertionSort();
            int[] elements = new int[4] { 3, 2, 1, -1 };
            insertionSort.Sort(elements, 3);
            Assert.AreEqual(1, elements[0]);
            Assert.AreEqual(2, elements[1]);
            Assert.AreEqual(3, elements[2]);
            Console.Write(insertionSort.LastMovingCount);
        }

        [TestMethod]
        public void InsertionSort_1706359_return0135679()
        {
            InsertionSort insertionSort = new InsertionSort();
            int[] elements = new int[8] { 1, 7, 0, 6, 3, 5, 9, -1 };
            insertionSort.Sort(elements, 7);
            Assert.AreEqual(0, elements[0]);
            Assert.AreEqual(1, elements[1]);
            Assert.AreEqual(3, elements[2]);
            Assert.AreEqual(5, elements[3]);
            Assert.AreEqual(6, elements[4]);
            Assert.AreEqual(7, elements[5]);
            Assert.AreEqual(9, elements[6]);
            Console.Write(insertionSort.LastMovingCount);
        }
    }
}
