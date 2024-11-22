using System;
namespace C_LeetCode
{
    /*请你仅使用两个队列实现一个后入先出（LIFO）的栈，并支持普通栈的全部四种操作（push、top、pop 和 empty）。
实现 MyStack 类：
void push(int x) 将元素 x 压入栈顶。
int pop() 移除并返回栈顶元素。
int top() 返回栈顶元素。
boolean empty() 如果栈是空的，返回 true ；否则，返回 false 。
     */
    
    public class MyStack
    {
        // 一个队列就够了
        Queue<int> queue; 
        public MyStack()
        {
            queue = new();
        }

        public void Push(int x)
        {
            // 先把x加进来，再把x前的所有元素出队再入队，放到后面
            int n = queue.Count;
            queue.Enqueue(x);
            for (int i = 0;i<n;i++)
            {
                int temp = queue.Dequeue();
                queue.Enqueue(temp);
            }
        }

        public int Pop()
        {

            return queue.Dequeue();
        }

        public int Top()
        {
            return queue.Peek();
        }

        public bool Empty()
        {
            return queue.Count == 0;
        }
    }
}

