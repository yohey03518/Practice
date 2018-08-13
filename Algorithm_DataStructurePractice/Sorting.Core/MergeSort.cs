using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.Core
{
    /// <summary>
    /// 合併排序法
    /// </summary>
    public class MergeSort
    {
        /// <summary>
        /// 執行排序 (遞增)
        /// </summary>
        /// <param name="elements">要排序的元素</param>
        /// <param name="count">元素數量</param>
        /// <returns></returns>
        public void Sort(int[] elements, int count)
        {
            int[] tempList = new int[count];
            int size = 1;

            while (size < count)
            {
                _MergeFor1Rount(elements, tempList, count, size);
                size *= 2;
                _MergeFor1Rount(tempList, elements, count, size);
                size *= 2;
            }
        }

        /// <summary>
        /// 執行一輪的合併排序
        /// </summary>
        /// <param name="elements">原陣列</param>
        /// <param name="mergedList">合併完成的陣列</param>
        /// <param name="allCount">全部元素數量</param>
        /// <param name="mergeSize">此次合併的一組元素的數量</param>
        private void _MergeFor1Rount(int[] elements, int[] mergedList, int allCount, int mergeSize)
        {
            int endIdx = allCount - 1;
            int i;
            for (i = 0; (i + 2 * mergeSize - 1) <= endIdx; i += 2 * mergeSize)
            {
                // (i + 2 * mergeSize - 1)為一組合併的右陣列結尾索引
                MergerTwoSortedList(elements, mergedList, i, i + mergeSize - 1, (i + 2 * mergeSize - 1));
            }
            // 此判斷式在前項迴圈執行完後代表剩餘元素量不足兩份的size但是足夠一份，所以要讓後面的一份和多的部分合併
            if (i + mergeSize < allCount)
                MergerTwoSortedList(elements, mergedList, i, i + mergeSize - 1, allCount - 1);
            // 走到這邊代表此次已經執行過合併，剩下的元素先併上去即可，不要再執行合併
            else
                for (int k = i; k <= allCount - 1; k++)
                    mergedList[k] = elements[k];
        }

        /// <summary>
        /// 合併陣列中兩個已排序好的連續區段
        /// </summary>
        /// <param name="elements">原陣列，含兩段連續的已排序好的區段</param>
        /// <param name="mergedList">合併完成的陣列</param>
        /// <param name="startIdx">起始索引</param>
        /// <param name="centerIdx">中間索引(第一段的結束索引)</param>
        /// <param name="endIndex">結尾索引</param>
        public void MergerTwoSortedList(int[] elements, int[] mergedList, int startIdx, int centerIdx, int endIndex)
        {
            int firstPartIdx = startIdx, secondPartIdx = centerIdx + 1;
            int mergedIdx = startIdx;

            // 兩個區段逐一比對大小，將結果放到mergedList
            while (firstPartIdx <= centerIdx && secondPartIdx <= endIndex)
            {
                if (elements[firstPartIdx] >= elements[secondPartIdx])
                    mergedList[mergedIdx++] = elements[secondPartIdx++];
                else
                    mergedList[mergedIdx++] = elements[firstPartIdx++];
            }

            // 比對到其中一段已經結束，則將另一段剩下的元素都加進mergedList
            // 第一個區段已經比較完，把第二區段剩下的都加進去；反之亦然
            if (firstPartIdx > centerIdx)
                for (int i = secondPartIdx; i <= endIndex; i++)
                    mergedList[mergedIdx++] = elements[i];
            else
                for (int i = firstPartIdx; i <= centerIdx; i++)
                    mergedList[mergedIdx++] = elements[i];
        }
    }
}
