using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sorting.Core;

namespace Sorting.Test
{
    [TestClass]
    public class BinaryInsertionSortTest
    {
        [TestMethod]
        public void BinaryInsertionSort_3_return3()
        {
            BinaryInsertionSort BinaryInsertionSort = new BinaryInsertionSort();
            int[] elements = new int[2] { 3, -1 };
            BinaryInsertionSort.Sort(elements, 1);
            Assert.AreEqual(3, elements[0]);
            Console.Write(BinaryInsertionSort.LastMovingCount);
        }

        [TestMethod]
        public void BinaryInsertionSort_123_return123()
        {
            BinaryInsertionSort BinaryInsertionSort = new BinaryInsertionSort();
            int[] elements = new int[4] { 1, 2, 3, -1 };
            BinaryInsertionSort.Sort(elements, 3);
            Assert.AreEqual(1, elements[0]);
            Assert.AreEqual(2, elements[1]);
            Assert.AreEqual(3, elements[2]);
            Console.Write(BinaryInsertionSort.LastMovingCount);
        }

        [TestMethod]
        public void BinaryInsertionSort_321_return123()
        {
            BinaryInsertionSort BinaryInsertionSort = new BinaryInsertionSort();
            int[] elements = new int[4] { 3, 2, 1, -1 };
            BinaryInsertionSort.Sort(elements, 3);
            Assert.AreEqual(1, elements[0]);
            Assert.AreEqual(2, elements[1]);
            Assert.AreEqual(3, elements[2]);
            Console.Write(BinaryInsertionSort.LastMovingCount);
        }

        [TestMethod]
        public void BinaryInsertionSort_1706359_return0135679()
        {
            BinaryInsertionSort BinaryInsertionSort = new BinaryInsertionSort();
            int[] elements = new int[8] { 1, 7, 0, 6, 3, 5, 9, -1 };
            BinaryInsertionSort.Sort(elements, 7);
            Assert.AreEqual(0, elements[0]);
            Assert.AreEqual(1, elements[1]);
            Assert.AreEqual(3, elements[2]);
            Assert.AreEqual(5, elements[3]);
            Assert.AreEqual(6, elements[4]);
            Assert.AreEqual(7, elements[5]);
            Assert.AreEqual(9, elements[6]);
            Console.Write(BinaryInsertionSort.LastMovingCount);
        }

        [TestMethod]
        public void BinaryInsertionSort_1257896_return1257896()
        {
            BinaryInsertionSort BinaryInsertionSort = new BinaryInsertionSort();
            int[] elements = new int[8] { 1, 2, 5, 7, 8, 9, 6, -1 };
            BinaryInsertionSort.Sort(elements, 7);
            Assert.AreEqual(1, elements[0]);
            Assert.AreEqual(2, elements[1]);
            Assert.AreEqual(5, elements[2]);
            Assert.AreEqual(6, elements[3]);
            Assert.AreEqual(7, elements[4]);
            Assert.AreEqual(8, elements[5]);
            Assert.AreEqual(9, elements[6]);
            Console.Write(BinaryInsertionSort.LastMovingCount);
        }
    }
}
