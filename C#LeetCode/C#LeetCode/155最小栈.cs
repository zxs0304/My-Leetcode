
using System;
namespace C_LeetCode
{
    /*设计一个支持 push ，pop ，top 操作，并能在常数时间内检索到最小元素的栈。实现 MinStack 类:
MinStack() 初始化堆栈对象。
void push(int val) 将元素val推入堆栈。
void pop() 删除堆栈顶部的元素。
int top() 获取堆栈顶部的元素。
int getMin() 获取堆栈中的最小元素。
	 */

    // 二元组的做法更好
    //在 stack 中存储一个包含两个部分的元组：元素的值和当前的最小值
    class MinStack
    {
        private Stack<(int value, int currentMin)> stack;
        public MinStack()
        {
            stack = new Stack<(int value, int currentMin)>();
        }
        public void Push(int x)
        {
            // 如果栈为空，或者x的值比之前的最小值还要小，新的最小值就是 x；
            // 否则，新的最小值还是之前的最小值
            int newMin;
            if (stack.Count == 0 || x <= stack.Peek().currentMin)
                newMin = x;
            else
                newMin = stack.Peek().currentMin;

            stack.Push((x, newMin));
        }

        public void Pop()
        {
            if (stack.Count > 0)
            {
                stack.Pop();
            }
        }

        public int Top()
        {
            return stack.Peek().value;
        }

        public int GetMin()
        {
            return stack.Peek().currentMin;
        }
    }

    // 辅助栈的做法
    class MinStack2
    {
        //借用一个辅助栈 min_stack，用于存获取 stack 中最小值。
        //每当push()新值进来时，如果小于等于 min_stack 栈顶值，则一起 push() 到 min_stack，即更新了辅助栈顶最小值；
        //判断将 pop() 出去的元素值是否是 min_stack 栈顶元素值（即最小值），如果是则将 min_stack 栈顶元素一起 pop()，这样可以保证 min_stack 栈顶元素始终是 stack 中的最小值。
        private Stack<int> stack;
        private Stack<int> min_stack;
        public MinStack2()
        {
            stack = new();
            min_stack = new();
        }
        public void Push(int x)
        {
            stack.Push(x);
            if (min_stack.Count == 0 || x <= min_stack.Peek())
                min_stack.Push(x);
        }
        public void Pop()
        {
            if (stack.Pop() == min_stack.Peek())
                min_stack.Pop();
        }
        public int Top()
        {
            return stack.Peek();
        }
        public int GetMin()
        {
            return min_stack.Peek();
        }
    }



}



