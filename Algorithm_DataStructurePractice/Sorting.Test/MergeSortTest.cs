using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sorting.Core;

namespace Sorting.Test
{
    [TestClass]
    public class MergeSortTest
    {
        [TestMethod]
        public void MergerTwoSortedList_9158237_return9123578()
        {
            MergeSort mergeSort = new MergeSort();
            int[] elements = new int[7] {9, 1, 5, 8, 2, 3, 7 };
            int[] result = new int[7];
            mergeSort.MergerTwoSortedList(elements, result, 1, 3, 6);
            Assert.AreEqual(1, result[1]);
            Assert.AreEqual(2, result[2]);
            Assert.AreEqual(3, result[3]);
            Assert.AreEqual(5, result[4]);
            Assert.AreEqual(7, result[5]);
            Assert.AreEqual(8, result[6]);
        }

        [TestMethod]
        public void MergerTwoSortedList_158237_return123578()
        {
            MergeSort mergeSort = new MergeSort();
            int[] elements = new int[6] { 1, 5, 8, 2, 3, 7 };
            int[] result = new int[6];
            mergeSort.MergerTwoSortedList(elements, result, 0, 2, 5);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(2, result[1]);
            Assert.AreEqual(3, result[2]);
            Assert.AreEqual(5, result[3]);
            Assert.AreEqual(7, result[4]);
            Assert.AreEqual(8, result[5]);
        }


        [TestMethod]
        public void MergeSort_5_return5()
        {
            MergeSort mergeSort = new MergeSort();
            int[] elements = new int[1] { 5 };
            mergeSort.Sort(elements, 1);
            Assert.AreEqual(5, elements[0]);
        }

        [TestMethod]
        public void MergeSort_426_return246()
        {
            MergeSort mergeSort = new MergeSort();
            int[] elements = new int[3] { 4, 2, 6 };
            mergeSort.Sort(elements, 3);
            Assert.AreEqual(2, elements[0]);
            Assert.AreEqual(4, elements[1]);
            Assert.AreEqual(6, elements[2]);
        }

        [TestMethod]
        public void MergeSort_426973_return234679()
        {
            MergeSort mergeSort = new MergeSort();
            int[] elements = new int[6] { 4, 2, 6, 9, 7, 3 };
            mergeSort.Sort(elements, 6);
            Assert.AreEqual(2, elements[0]);
            Assert.AreEqual(3, elements[1]);
            Assert.AreEqual(4, elements[2]);
            Assert.AreEqual(6, elements[3]);
            Assert.AreEqual(7, elements[4]);
            Assert.AreEqual(9, elements[5]);
        }

        [TestMethod]
        public void MergeSort_123_return123()
        {
            MergeSort mergeSort = new MergeSort();
            int[] elements = new int[3] { 1, 2, 3 };
            mergeSort.Sort(elements, 3);
            Assert.AreEqual(1, elements[0]);
            Assert.AreEqual(2, elements[1]);
            Assert.AreEqual(3, elements[2]);
        }

        [TestMethod]
        public void MergeSort_321_return123()
        {
            MergeSort mergeSort = new MergeSort();
            int[] elements = new int[3] { 3, 2, 1 };
            mergeSort.Sort(elements, 3);
            Assert.AreEqual(1, elements[0]);
            Assert.AreEqual(2, elements[1]);
            Assert.AreEqual(3, elements[2]);
        }

        [TestMethod]
        public void MergeSort_1706359_return0135679()
        {
            MergeSort mergeSort = new MergeSort();
            int[] elements = new int[7] { 1, 7, 0, 6, 3, 5, 9 };
            mergeSort.Sort(elements, 7);
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
