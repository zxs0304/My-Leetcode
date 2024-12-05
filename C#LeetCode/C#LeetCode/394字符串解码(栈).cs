using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    /*给定一个经过编码的字符串，返回它解码后的字符串。
编码规则为: k[encoded_string]，表示其中方括号内部的 encoded_string 正好重复 k 次。注意 k 保证为正整数。
你可以认为输入字符串总是有效的；输入字符串中没有额外的空格，且输入的方括号总是符合格式要求的。
此外，你可以认为原始数据不包含数字，所有的数字只表示重复的次数 k ，例如不会出现像 3a 或 2[4] 的输入。
输入：s = "3[a]2[bc]"
输出："aaabcbc"
输入：s = "3[a2[c]]"
输出："accaccacc"
输入：s = "2[abc]3[cd]ef"
输出："abcabccdcdcdef"
输入：s = "abc3[cd]xyz"
输出："abccdcdcdxyz"
     */
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
