using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _739每日温度_栈_
    {
        //单调栈: 使用递减栈来保持索引,栈中的元素是按照温度从高到低的顺序存储的，栈顶元素表示当前未找到下一个更高温度的日期。
        //遍历数组: 遍历数组,如果当前温度大于栈顶索引所对应的温度，说明栈顶索引找到了下一个更高的温度(就是当前天)。
        //如果当前温度小于栈顶那天的温度，说明栈顶的元素还没找到下一个最高温度
        //将当前索引压入栈中。
        public int[] DailyTemperatures(int[] temperatures)
        {
            int n = temperatures.Length;
            int[] result = new int[n];
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                while (stack.Count > 0 && temperatures[i] > temperatures[stack.Peek()])
                {
                    int index = stack.Pop();
                    result[index] = i - index; // 计算天数差
                }
                stack.Push(i); // 将当前天数索引入栈
            }

            return result; // 返回结果数组
        }
    }
}
