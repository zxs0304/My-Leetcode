// FileName：232两个栈实现队列.cs
// Author：duole-15
// Date：2024/11/22
// Des：描述
using System;
namespace C_LeetCode
{
    // 需要出队时，若stack2.count为0时，就转移stack1中的元素到stack2中,此时顺序仍然是正确的
    public class MyQueue
    {
        private Stack<int> stack1; // 用于入队
        private Stack<int> stack2; // 用于出队

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

