using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.Core
{
    /// <summary>
    /// 快速排序法
    /// </summary>
    public class QuickSort
    {
        /// <summary>
        /// 執行排序 (遞增)
        /// </summary>
        /// <param name="elements">要排序的元素，透過left和right指定要排序的區段，並確保right+1位址值大於等於left的值</param>
        /// <param name="left">要排序的左邊索引</param>
        /// <param name="right">要排序的右邊索引</param>
        /// <returns></returns>
        public void Sort(int[] elements, int left, int right)
        {
            if (left < right)
            {
                if (elements[right + 1] < elements[left])
                    throw new NotSupportedException("Right+1的值小於left的值，無法進行排序");
                int i = left, j = right + 1;
                int pivotIndex = left;
                int pivot = elements[pivotIndex];
                do
                {
                    do i++; while (elements[i] < pivot);
                    do j--; while (elements[j] > pivot);
                    // 經過一輪i和j的走訪，在i < j的情況下代表i位址的值必定大於pivot，而j的位置必定小於pivot，因此做交換
                    if (i < j) _Swap(elements, i, j);
                } while (i < j);
                // 此時j位址的值必定小於pivot，故和pivot做交換
                _Swap(elements, pivotIndex, j);
                // 交換完畢後會變成pivot左邊的值都小於pivot，pivot右邊的值都大於pivot，於是再各別做一次QuickSort
                Sort(elements, left, j - 1);
                Sort(elements, j + 1, right);
            }
        }

        /// <summary>
        /// 值交換
        /// </summary>
        /// <param name="elements"></param>
        /// <param name="index1"></param>
        /// <param name="index2"></param>
        private void _Swap(int[] elements, int index1, int index2)
        {
            int temp = elements[index1];
            elements[index1] = elements[index2];
            elements[index2] = temp;
        }
    }
}
