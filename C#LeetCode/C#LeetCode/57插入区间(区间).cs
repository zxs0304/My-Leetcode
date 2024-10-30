using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _57插入区间_区间_
    {
        public int[][] Insert(int[][] intervals, int[] newInterval)
        {
            List <int[]> result = new List <int[]>();
            //两个区间不重叠的条件是 (nums[i].end < nums[i + 1].start) (对于已经按start排序的数组) 
            //反之重叠的条件是 (nums[i].end >= nums[j].start) && (nums[i].start >= nums[j].end)

            int i = 0;
            while (i < intervals.Length && intervals[i][1] < newInterval[0]) //先将新区间前面的不重叠的区间给加进去
            {
                result.Add(intervals[i]);
                i++;
            }

            //将所有与新区间重叠的区间合并成一个,由于前面不重叠的区间(old.end < new.start)已经加入过了， 因此判断条件只需要new.end >= old.start即可
            while (i < intervals.Length && newInterval[1] >= intervals[i][0])
            {
                newInterval[0] = Math.Min(newInterval[0], intervals[i][0]);
                newInterval[1] = Math.Max(newInterval[1], intervals[i][1]);
                i++;
            }
            result.Add(newInterval);

            while (i < intervals.Length) //把剩余后面不重叠的区间给加进去
            {
                result.Add(intervals[i]);
                i++;
            }

            return result.ToArray();

        }

    }
}
