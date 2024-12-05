// FileName：150逆波兰表达式求值(栈).cs
// Author：duole-15
// Date：2024/12/5
// Des：描述
using System;
namespace C_LeetCode
{
    /*150. 逆波兰表达式求值
给你一个字符串数组 tokens ，表示一个根据 逆波兰表示法 表示的算术表达式。请你计算该表达式。返回一个表示表达式值的整数。
有效的算符为 '+'、'-'、'*' 和 '/' 。每个操作数（运算对象）都可以是一个整数或者另一个表达式。两个整数之间的除法总是 向零截断 。表达式中不含除零运算。
输入是一个根据逆波兰表示法表示的算术表达式。答案及所有中间计算结果可以用 32 位 整数表示。
输入：tokens = ["2","1","+","3","*"]
输出：9
解释：该算式转化为常见的中缀算术表达式为：((2 + 1) * 3) = 9
输入：tokens = ["4","13","5","/","+"]
输出：6
解释：该算式转化为常见的中缀算术表达式为：(4 + (13 / 5)) = 6
输入：tokens = ["10","6","9","3","+","-11","*","/","*","17","+","5","+"]
输出：22
解释：该算式转化为常见的中缀算术表达式为：
  ((10 * (6 / ((9 + 3) * -11))) + 17) + 5
= ((10 * (6 / (12 * -11))) + 17) + 5
= ((10 * (6 / -132)) + 17) + 5
= ((10 * 0) + 17) + 5
= (0 + 17) + 5
= 17 + 5
= 22
	 */
    public class _50逆波兰表达式求值_栈_
	{
        public int EvalRPN(string[] tokens)
        {
            Stack<int> numbers = new();
            foreach (string str in tokens)
            {
                // 是符号
                if (str == "+" || str == "-" || str == "*" || str == "/")
                {
                    int number1 = numbers.Pop();
                    int number2 = numbers.Pop();
                    int result = 0;
                    switch (str)
                    {
                        case "+":
                            result = number2 + number1;
                            break;
                        case "-":
                            result = number2 - number1;
                            break;
                        case "*":
                            result = number2 * number1;
                            break;
                        case "/":
                            result = number2 / number1;
                            break;
                    }
                    numbers.Push(result);
                } 
                else // 是数字
                {
                    // parse可以正确解析负数字符串 如"-1"
                    int number = int.Parse(str);
                    numbers.Push(number);
                }
            }

            return numbers.Pop();
        }

    }
}

