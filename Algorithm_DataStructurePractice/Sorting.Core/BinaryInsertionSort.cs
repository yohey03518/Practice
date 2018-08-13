using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.Core
{
    /// <summary>
    /// 二元插入排序法
    /// </summary>
    public class BinaryInsertionSort
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
                _BinaryInsert(elements, index, elements[index]);
            }
        }

        /// <summary>
        /// 二元搜尋插入法
        /// </summary>
        /// <param name="sortedElements"></param>
        /// <param name="originalCount">原本排序好的元素數量</param>
        /// <param name="newElement">新加入的元素</param>
        private void _BinaryInsert(int[] sortedElements, int originalCount, int newElement)
        {
            // 透過兩個指標決定二元搜尋的範圍
            int searchStartIndex = 0, searchEndIndex = originalCount - 1;
            // 由兩指標的中間值決定中間點
            int centerIndex = (searchStartIndex + searchEndIndex) / 2;
            for ( ; searchStartIndex <= searchEndIndex;
                centerIndex = (searchStartIndex + searchEndIndex) / 2)
            {
                // 當新加入的元素小於此中間點的值，則將二元搜尋的右範圍移至中間點的左邊
                if (newElement < sortedElements[centerIndex])
                {
                    searchEndIndex = centerIndex - 1;
                }
                // 當新加入的元素大於此中間點的值，則將二元搜尋的左範圍移至中間點的右邊
                if (sortedElements[centerIndex] < newElement)
                {
                    searchStartIndex = centerIndex + 1;
                }
            }
            // 最終當離開迴圈時，center的值就是最後要比對的位置
            if (sortedElements[centerIndex] < newElement)
            {
                _MoveArray(sortedElements, centerIndex + 1, originalCount - centerIndex - 1);
                sortedElements[centerIndex + 1] = newElement;
            }
            else if (newElement < sortedElements[centerIndex])
            {
                _MoveArray(sortedElements, centerIndex, originalCount - centerIndex);
                sortedElements[centerIndex] = newElement;
            }
        }

        /// <summary>
        /// 陣列元素向後移一格
        /// </summary>
        /// <param name="elements"></param>
        /// <param name="moveStartIndex">從index幾開始移動</param>
        /// <param name="moveElementCount">總共要移動幾個元素</param>
        private void _MoveArray(int[] elements, int moveStartIndex, int moveElementCount)
        {
            for (int movingElementIndex = moveStartIndex + moveElementCount - 1; movingElementIndex >= moveStartIndex; movingElementIndex--)
            {
                LastMovingCount++;
                elements[movingElementIndex + 1] = elements[movingElementIndex];
            }
        }
    }
}
