using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _232用栈实现队列
    {

        public class MyQueue
        {
            private Stack<int> stack1;
            private Stack<int> stack2;
            public MyQueue()
            {
                stack1 = new Stack<int>();
                stack2 = new Stack<int>();
            }

            public void Push(int x)
            {
                stack1.Push(x);
            }

            public int Pop()
            {
                if (stack2.Count == 0) //当stack2为0时，就转移stack1中的元素到stack2中
                {
                    while (stack1.Count > 0)
                    {
                        stack2.Push(stack1.Pop());
                    }
                }
                
                return stack2.Pop();

            }

            public int Peek()
            {
                if (stack2.Count == 0) //当stack2为0时，就转移stack1中的元素到stack2中
                {
                    while (stack1.Count > 0)
                    {
                        stack2.Push(stack1.Pop());
                    }
                }

                return stack2.Peek();
            }

            public bool Empty()
            {
                return stack1.Count == 0 && stack2.Count == 0;
            }
        }

    }
}
