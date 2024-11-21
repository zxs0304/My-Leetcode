using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _20有效的括号_栈_
    {
        //遍历给定的字符串 s,当遇到一个左括号时，我们会期望在后续的遍历中，有一个相同类型的右括号将其闭合。
        //由于后遇到的左括号要先闭合，因此我们可以将这个左括号放入栈顶。
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i]=='[' || s[i] == '{' || s[i] =='(')
                {
                    stack.Push(s[i]);
                }
                else //当前是右括号，则上一个入栈的左括号必须要和现在这个右括号匹配
                {
                    switch (s[i])
                    {
                        case ']':
                            if (stack.Count == 0 || stack.Pop() != '[')
                                return false;
                            break;
                        case '}':
                            if (stack.Count == 0 || stack.Pop() != '{')
                                return false;
                            break;
                        case ')':
                            if (stack.Count == 0 || stack.Pop() != '(')
                                return false;
                            break;
                    }
                   
                }

            }
            // 最后不能有剩余的左括号
            return stack.Count == 0 ? true : false;
        }
    }
}
