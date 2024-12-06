// FileName：373查找和最小的K对数字.cs
// Author：duole-15
// Date：2024/12/6
// Des：描述
using System;
using System.Collections.Generic;

namespace C_LeetCode
{
    /*373. 查找和最小的 K 对数字
给定两个以 非递减顺序排列 的整数数组 nums1 和 nums2 , 以及一个整数 k 。定义一对值 (u,v)，其中第一个元素来自 nums1，第二个元素来自 nums2 。
请找到和最小的 k 个数对 (u1,v1),  (u2,v2)  ...  (uk,vk) 。
输入: nums1 = [1,7,11], nums2 = [2,4,6], k = 3
输出: [1,2],[1,4],[1,6]
解释: 返回序列中的前 3 对数：
     [1,2],[1,4],[1,6],[7,2],[7,4],[11,2],[7,6],[11,4],[11,6]
输入: nums1 = [1,1,2], nums2 = [1,2,3], k = 2
输出: [1,1],[1,1]
解释: 返回序列中的前 2 对数：
     [1,1],[1,1],[1,2],[2,1],[1,2],[2,2],[1,3],[1,3],[2,3]
	 */
    public class _73查找和最小的K对数字
	{
        //难
        // 对于下标(i,j),初始把 (0,0) 入堆。每次出堆时，可能成为下一个数对的是(i+1, j) 和(i, j+1)，这俩入堆。其它的不会比这两个更小。
        //但这会导致一个问题：例如当(1,0) 出堆时，会把(1,1) 入堆；当(0,1) 出堆时，也会把(1,1) 入堆，这样堆中会有重复元素。
        //为了避免有重复元素，还需要额外用一个哈希表记录在堆中的下标对。只有当下标对不在堆中时，才能入堆。能否不用哈希表呢
        // 可以在(i, j) 出堆时，只需将(i, j+1) 入堆，无需将(i+1, j) 入堆。
        //但若按照该规则，初始仅把(0,0) 入堆的话，只会得到(0,1),(0,2),⋯ 这些下标对。
        //所以初始不仅要把(0,0) 入堆，(1,0),(2,0),⋯ 这些都要提前入堆。

        public IList<IList<int>> KSmallestPairs(int[] nums1, int[] nums2, int k)
        {
            List<IList<int>> result = new List<IList<int>>();
            // 边界条件
            if (nums1.Length == 0 || nums2.Length == 0)
            {
                return result;
            }

            // 最小堆
            PriorityQueue<(int i, int j), int> minHeap = new PriorityQueue<(int i, int j),int>();

            // 初始化堆，将每个nums1元素与 nums2 的第一个元素组合
            for (int i = 0; i < Math.Min(k, nums1.Length); i++)
            {
                minHeap.Enqueue((i, 0), nums1[i] + nums2[0]);
            }


            while (result.Count < k)
            {
                (int i ,int j) = minHeap.Dequeue();
                result.Add(new int[] { nums1[i], nums2[j] });
                if (j+1<nums2.Length)
                {
                    minHeap.Enqueue((i, j + 1), nums1[i] + nums2[j + 1]);
                }
            }
            return result;

        }
    }
}

