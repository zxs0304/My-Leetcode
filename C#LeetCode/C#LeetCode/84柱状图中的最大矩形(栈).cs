// FileName：84柱状图中的最大矩形(栈).cs
// Author：duole-15
// Date：2024/12/6
// Des：描述
using System;
namespace C_LeetCode
{
    /*84. 柱状图中最大的矩形
给定 n 个非负整数，用来表示柱状图中各个柱子的高度。每个柱子彼此相邻，且宽度为 1 。
求在该柱状图中，能够勾勒出来的矩形的最大面积。
输入：heights = [2,1,5,6,2,3]
输出：10
解释：最大的矩形为图中红色区域，面积为 10
输入： heights = [2,4]
输出： 4
	 */
    public class _84柱状图中的最大矩形_栈_
	{
        //对于每个柱子的高度，要想求以它为高的最大矩形面积，那么就要找到以它为高时，最大的宽。
        //分别向左和向右 找到第一个比它低的柱子位置，right - left - 1 (因为不包含right 也不包含left) ,这就是最大宽度。
        //使用单调栈遍历柱子的高度数组，并存储柱子的索引。栈中的柱子索引将按高度从低到高排列。
        //当遇到当前的柱子高度小于栈顶的的高度时，说明当前柱子的位置 是栈顶柱子的 右边界。我们将弹出栈顶元素，并计算以这个高度的矩形面积。
        //遍历柱子的高度数组，通过栈来维护一个单调递增序列的索引。

        public int LargestRectangleArea(int[] heights)
        {
            int n = heights.Length + 2;
            int[] allHeights = new int[n];
            //!!!!开头和末尾加个0
            //在算法中，我们总是需要找到栈顶柱子的左边界。在最左端添加0，可以确保栈中至少会有一个元素（代表左边界的虚拟柱子），从而避免栈为空的情况。
            //另外在最右端添加0，当遍历到数组末尾的0时，一定会小于当前的栈顶元素，从而不会漏掉栈中一些元素。
            Array.Copy(heights, 0, allHeights, 1, heights.Length);
            allHeights[0] = 0;
            allHeights[n - 1] = 0;
            Stack<int> indexes = new();
            int maxArea = 0;
            for (int i = 0; i < n; i++)
            {
                // 循环地从栈中取出所有 高度大于当前高度 的柱子，代表着当前柱子是他们的右边界
                while (indexes.Count > 0 && allHeights[i] < allHeights[indexes.Peek()])
                {
                    // 获得栈顶柱子索引，也是要求的高度
                    int curIndex = indexes.Pop();
                    int curHeight = allHeights[curIndex];
                    // 栈顶柱子的右边界是i
                    int right = i;
                    // 左边界是栈顶元素的前一个元素 (因为是单调递增栈)
                    int left = indexes.Peek();
                    // 栈顶柱子对应的最大宽度
                    int width = right - left - 1;
                    // 栈顶柱子的最大面积
                    int curMaxArea = curHeight * width;

                    maxArea = Math.Max(curMaxArea, maxArea);
                }
                indexes.Push(i);
            }

            return maxArea;
        }
    }
}

