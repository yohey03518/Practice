using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.Core
{
    /// <summary>
    /// 插入排序法
    /// </summary>
    public class InsertionSort
    {
        /// <summary>
        /// 上一次排序的移動元素次數
        /// </summary>
        public int LastMovingCount = 0;

        /// <summary>
        /// 執行排序 (遞增)
        /// </summary>
        /// <param name="elements">未排序的元素，從0開始</param>
        /// <param name="count">元素數量</param>
        /// <returns></returns>
        public void Sort(int[] elements, int count)
        {
            LastMovingCount = 0;
            for (int index = 1; index < count; index++)
            {
                // 此時的index正好是原本已排好的數量
                _Insert(elements, index, elements[index]);
            }
        }

        /// <summary>
        /// 將一個元素插入一組已經排序好的陣列中
        /// </summary>
        /// <param name="sortedElements">已排序好的陣列</param>
        /// <param name="originalCount">原本的數量</param>
        /// <param name="newElement">新加入的元素</param>
        private void _Insert(int[] sortedElements, int originalCount, int newElement)
        {
            // 指向最後一個元素
            int index = originalCount - 1;
            while (index >= 0/*避免比對到最後一個元素*/ && newElement < sortedElements[index])
            {
                // 被比對的那一個元素比新加入的還大，往後移一格
                sortedElements[index + 1] = sortedElements[index];
                LastMovingCount++;
                index--;
            }
            sortedElements[index + 1] = newElement;
        }
    }
}
