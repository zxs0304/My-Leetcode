using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _71简化路径_栈_
    {
        
        public string SimplifyPath(string path)
        {
            //通过'/'分割成一个个子串，神之一笔，很方便！！！
            string[] names = path.Split("/");
            Stack<string> stack = new Stack<string>();
            foreach (string name in names)
            {
                if (name.Equals(".."))
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                }
                // 如果长度大于0 (避免了///),且不是一个. 就入栈
                else if (name.Length > 0 && !name.Equals("."))
                {
                    stack.Push(name);
                }
            }
            StringBuilder sb = new StringBuilder();
            //空路径的情况 也要有个'/'
            if (stack.Count == 0)
            {
                sb.Append('/');
            }
            else
            {
                while (stack.Count > 0)
                {
                    sb.Insert(0,stack.Pop());
                    sb.Insert(0, '/');
                }
            }
            return sb.ToString();
        }
    }
}
