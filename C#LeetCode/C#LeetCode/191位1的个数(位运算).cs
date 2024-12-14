﻿// FileName：191位1的个数(位运算).cs
// Author：duole-15
// Date：2024/12/14
// Des：描述
using System;
namespace C_LeetCode
{
    /*191. 位1的个数
给定一个正整数 n，编写一个函数，获取一个正整数的二进制形式并返回其二进制表达式中 设置位 1 的个数（也被称为汉明重量）。
输入：n = 11
输出：3
解释：输入的二进制串 1011 中，共有 3 个设置位。
输入：n = 128
输出：1
解释：输入的二进制串 10000000 中，共有 1 个设置位。

输入：n = 2147483645
输出：30
解释：输入的二进制串 1111111111111111111111111111101 中，共有 30 个设置位。
	 */
    public class _191位1的个数_位运算_
	{
        // 每次将 n 与 n-1 做与运算，都会将 n 的最低位的 1 变为 0。
        // 以 1011 举例
        // 第一次迭代:
        // 1011
        // 1010  =  1010
        // 第二次迭代:
        // 1010
        // 1001  =  1000
        // 第三次迭代:
        // 1000
        // 0111  =  0000 
        public int HammingWeight(int n)
        {
            int count = 0;
            while (n > 0)
            {
                count++;
                n = n & (n - 1);
            }
            return count;
        }
    }
}

