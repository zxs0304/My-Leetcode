using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class 最长中毒时间
    {

        public int CalculatePoisonedTime(int[] timeSeries, int duration)
        {
            if (timeSeries.Length == 0) return 0;

            int totalPoisonedTime = 0;
            int endPoisonTime = 0; // 记录中毒结束时间

            for (int i = 0; i < timeSeries.Length; i++)
            {
                if (timeSeries[i] >= endPoisonTime)
                {
                    // 如果当前攻击时间在上一次中毒结束时间之后，则累加5秒
                    totalPoisonedTime += duration;
                }
                else
                {
                    // 如果当前攻击时间在上一次中毒结束时间之前，则只累加差值
                    totalPoisonedTime += (timeSeries[i] + duration) - endPoisonTime;
                }

                // 刷新中毒结束时间
                endPoisonTime = timeSeries[i] + duration;
            }

            return totalPoisonedTime;
        }

    }
}
