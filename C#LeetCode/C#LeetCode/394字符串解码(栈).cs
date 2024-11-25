using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _394字符串解码_栈_
    {
//        背步骤
//       使用栈来处理嵌套：当遇到一个[，我们知道将要开始一个新的编码部分。
//        在此之前，我们需要保存当前的状态（即当前的字符串和重复次数）。
     //[：表示新编码部分的开始，当前字符串和数字（重复次数）都要入栈 并 清空状态。
     //]：表示当前编码部分的结束，从栈中弹出上一个字符串和重复次数，构造重复的字符串并拼接到上一个字符串后面。
        public string DecodeString(string s)
        {
            Stack<int> numStack = new Stack<int>();
            Stack<string> strStack = new Stack<string>();
            StringBuilder currentString = new StringBuilder();
            int currentNum = 0;

            foreach (char c in s)
            {
                if (char.IsDigit(c))
                {
                    // 如果是数字，构造当前的数字
                    currentNum = currentNum * 10 + (c - '0');
                }
                else if (c == '[')
                {
                    // 如果是'['，将当前数字和字符串入栈
                    numStack.Push(currentNum);
                    strStack.Push(currentString.ToString());
                    currentNum = 0; // 重置当前数字
                    currentString.Clear(); // 清空当前字符串
                }
                else if (c == ']')
                {
                    // 如果是']'，弹出栈顶的字符串和数字
                    // 将当前的currentString重复后，并在前面加上栈顶的字符串。将这个字符串变成当前字符串
                    string prevString = strStack.Pop();
                    int repeatTimes = numStack.Pop();
                    StringBuilder repeatedString = new StringBuilder();
                    for (int k = 0;k<repeatTimes;k++)
                    {
                        repeatedString.Append(currentString.ToString());
                    }
                    currentString = repeatedString;
                    currentString.Insert(0,prevString);
                }
                else
                {
                    // 普通字符，加入到当前字符串
                    currentString.Append(c);
                }
            }

            return currentString.ToString();
        }

    }
}
