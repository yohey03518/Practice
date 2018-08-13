using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.Core
{
    /// <summary>
    /// 氣泡排序法
    /// </summary>
    public class BubbleSort
    {
        /// <summary>
        /// 執行排序 (遞增)
        /// </summary>
        /// <param name="elements">要排序的元素，從0開始</param>
        /// <param name="count">總數量</param>
        /// <returns></returns>
        public void Sort(int[] elements, int count)
        {
            // resultIdx: 每次迴圈要放置排序完成元素的位址
            for (int resultIdx = count - 1; resultIdx >= 0; resultIdx--)
            {
                int maxValue = elements[0], maxValueIdx = 0;
                for (int i = 1; i<= resultIdx; i++)
                {
                    if(elements[i] > maxValue)
                    {
                        maxValue = elements[i];
                        maxValueIdx = i;
                    }
                }
                _Swap(elements, maxValueIdx, resultIdx);
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
