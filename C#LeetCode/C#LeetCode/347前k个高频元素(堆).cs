using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _347前k个高频元素_堆_
    {
        //遍历数组使用哈希表记录每个数字出现的次数.
        //排序的做法：O( n logn)
        //构造一个小顶堆(默认PriorityQueue是小顶堆)，键是元素，值是出现频率，将哈希表中每个元素都插入到小顶堆中
        //保持堆中元素总数不超过k，当堆元素超过k个时，就弹出当前频率最小的元素，
        //由于,堆 插入和删除一个元素复杂度都为logk，因此总复杂度O(n logk)
        public int[] TopKFrequent(int[] nums, int k)
        {
            var dic = new Dictionary<int, int>();
            for (int i = 0;i< nums.Length;i++)
            {
                if (dic.ContainsKey(nums[i]))
                {
                    dic[nums[i]]++;
                }
                else
                {
                    dic[nums[i]] = 1;
                }
            }
            PriorityQueue<int,int> minHeap = new();
            foreach (var item in dic)
            {
                minHeap.Enqueue(item.Key,item.Value);
                if (minHeap.Count > k)
                {
                    minHeap.Dequeue();
                }
            }

            // 提取结果
            int[] result = new int[k];
            int index = 0;
            while (minHeap.Count > 0)
            {
                result[index++] = minHeap.Dequeue();
            }
            return result;
        }
    }
}
