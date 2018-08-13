using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.Core
{
    /// <summary>
    /// 堆積排序法
    /// </summary>
    public class HeapSort
    {
        /// <summary>
        /// 執行排序 (遞增)
        /// </summary>
        /// <param name="elements">要排序的元素，從1開始擺放</param>
        /// <param name="count">數量</param>
        /// <returns></returns>
        public void Sort(int[] elements, int count)
        {
            // 將樹前半段的元素依序進行一次最大堆積的調整，完成後的root會是最大值
            for (int i = count / 2; i > 0; i--)
                AdjustTree(elements, i, count);

            for(int k = count; k > 0; k--)
            {
                // 把目前最大的值放到陣列最後方後，把原先最後方的值放到root進行一次調整，會讓剩下的最大值移動到root
                _Swap(elements, 1, k);
                AdjustTree(elements, 1, k - 1);
            }
        }

        /// <summary>
        /// 針對指定的root節點做一次最大堆積的調整
        /// </summary>
        /// <param name="elements">樹結構以陣列表示，從1開始擺放</param>
        /// <param name="rootIndex">選定的節點</param>
        /// <param name="count">含root的全部節點數量</param>
        public void AdjustTree(int[] elements, int rootIndex, int count)
        {
            int rootValue = elements[rootIndex];
            // 下一階層的第一顆子樹(左子樹)
            int childIdx = rootIndex * 2;
            int lastIdx = count;
            // 在走訪子樹時未超出陣列都要繼續比對
            while (childIdx <= lastIdx)
            {
                // 檢查左子樹及右子樹(若存在的話)哪個較大，取出較大的那個
                if ((childIdx < lastIdx) && elements[childIdx] < elements[childIdx + 1])
                    childIdx++;
                // 選定的子樹和父節點比較，若父節點仍比較大，就停止比對(完成這次的調整)；
                // 若子樹較大，則把該子樹放到父節點，從該子樹繼續往下比對(父節點使用上比對較小的結果)
                if (rootValue > elements[childIdx])
                    break;
                else
                {
                    elements[childIdx / 2] = elements[childIdx];
                    childIdx *= 2;
                }
            }
            // 迴圈結束代表除了開始的root之外，其他點已完成一次的調整，此時仍須把原root的值放回最後的子節點上
            elements[childIdx / 2] = rootValue;
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
