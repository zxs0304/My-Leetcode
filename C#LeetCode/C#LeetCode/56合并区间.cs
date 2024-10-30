using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _56合并区间
    {
        public int[][] Merge(int[][] intervals)
        {
            IList<int[]> result = new List<int[]>();
            if (intervals.Length == 0) 
                return result.ToArray();
            // 2. 按照每个区间的起始值进行排序
            Array.Sort(intervals, (a, b) => { return a[0] - b[0]; });

            //两个区间重叠的条件是 (nums[i].end >= nums[i + 1].start) && (nums[i].start <= nums[i + 1].end )
            //对于已经按start排序后的数组来说，nums[i].start 一定是 <= nums[i+1].end ,因此只要判断nums[i].end >= nums[i + 1].start即可
            int[] curArray = intervals[0];
            for(int i = 1;i < intervals.Length; i++)
            {
                if (curArray[1] >= intervals[i][0])
                {
                    curArray[1] = Math.Max(curArray[1], intervals[i][1]);
                }
                else //没有与后一个区间重叠
                {
                    result.Add(new int[] { curArray[0], curArray[1] }); //不能直接添加curArray因为是引用，后续要改变
                    curArray = intervals[i];
                }

                
            }
            //出来以后，最后一个区间没有被添加
            result.Add(new int[] { curArray[0], curArray[1] });
            return result.ToArray();
        }

    }
}
