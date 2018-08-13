using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sorting.Core;

namespace Sorting.Test
{
    [TestClass]
    public class QuickSortTest
    {
        [TestMethod]
        public void QuickSort_5_return5()
        {
            QuickSort quickSort = new QuickSort();
            int[] elements = new int[2] { 5, 999 };
            quickSort.Sort(elements, 0, 0);
            Assert.AreEqual(5, elements[0]);
        }

        [TestMethod]
        public void QuickSort_426_return246()
        {
            QuickSort quickSort = new QuickSort();
            int[] elements = new int[4] { 4, 2, 6, 999 };
            quickSort.Sort(elements, 0, 2);
            Assert.AreEqual(2, elements[0]);
            Assert.AreEqual(4, elements[1]);
            Assert.AreEqual(6, elements[2]);
        }

        [TestMethod]
        public void QuickSort_426973_return234679()
        {
            QuickSort quickSort = new QuickSort();
            int[] elements = new int[7] { 4, 2, 6, 9, 7, 3, 999 };
            quickSort.Sort(elements, 0, 5);
            Assert.AreEqual(2, elements[0]);
            Assert.AreEqual(3, elements[1]);
            Assert.AreEqual(4, elements[2]);
            Assert.AreEqual(6, elements[3]);
            Assert.AreEqual(7, elements[4]);
            Assert.AreEqual(9, elements[5]);
        }

        [TestMethod]
        public void QuickSort_123_return123()
        {
            QuickSort quickSort = new QuickSort();
            int[] elements = new int[4] { 1, 2, 3, 999 };
            quickSort.Sort(elements, 0, 2);
            Assert.AreEqual(1, elements[0]);
            Assert.AreEqual(2, elements[1]);
            Assert.AreEqual(3, elements[2]);
        }

        [TestMethod]
        public void QuickSort_321_return123()
        {
            QuickSort quickSort = new QuickSort();
            int[] elements = new int[4] { 3, 2, 1, 999 };
            quickSort.Sort(elements, 0, 2);
            Assert.AreEqual(1, elements[0]);
            Assert.AreEqual(2, elements[1]);
            Assert.AreEqual(3, elements[2]);
        }

        [TestMethod]
        public void QuickSort_1706359_return0135679()
        {
            QuickSort quickSort = new QuickSort();
            int[] elements = new int[8] { 1, 7, 0, 6, 3, 5, 9, 999 };
            quickSort.Sort(elements, 0, 6);
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
