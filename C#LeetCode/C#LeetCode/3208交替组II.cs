
namespace C_LeetCode
{
    /*3208. 交替组 II
给你一个整数数组 colors 和一个整数 k ，colors表示一个由红色和蓝色瓷砖组成的环，第 i 块瓷砖的颜色为 colors[i] ：
colors[i] == 0 表示第 i 块瓷砖的颜色是 红色 。colors[i] == 1 表示第 i 块瓷砖的颜色是 蓝色 。
环中连续 k 块瓷砖的颜色如果是 交替 颜色（也就是说除了第一块和最后一块瓷砖以外，中间瓷砖的颜色与它 左边 和 右边 的颜色都不同），那么它被称为一个 交替 组。
请你返回 交替 组的数目。
注意 ，由于 colors 表示一个 环 ，第一块 瓷砖和 最后一块 瓷砖是相邻的。
输入：colors = [0,1,0,1,0], k = 3
输出：3
输入：colors = [0,1,0,0,1,0,1], k = 6
输出：2
	 */
    public class _208交替组II
	{
        //遍历数组，如果当前元素与前一个元素不同，alternateCount 加 1；否则，重置 alternateCount 为 1。
        //如果 alternateCount 大于或等于 k，则将 res 加 1。
        public int NumberOfAlternatingGroups(int[] colors, int k)
        {
            int n = colors.Length;
            int result = 0;
            int alternateCount = 1; // 当前连续交替瓷砖的数量
            // 第0个元素一定是交替瓷砖,因此从1开始遍历
            // 由于是个环，当最后一个(n-1)元素作为交替组的第一个元素时，最远能到达 (n-1) + (k -1) 位置，因此i <= n+k-2
            for (int i = 1; i <= n + k - 2; i++)
            {
                if (colors[i % n] != colors[(i - 1) % n])
                {
                    alternateCount++;
                }
                else
                {
                    alternateCount = 1;
                }
                if (alternateCount >= k)
                {
                    result++;
                }
            }
            return result;
        }
    }
}

