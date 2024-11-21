using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{

    class Student
    {


        public static void Main(string[] args)
        {
            _73矩阵置零_矩阵_ t = new _73矩阵置零_矩阵_();

            t.SetZeroes(
                new int[][]
                {
                new int[] { 1, 0,1 },          // 第一个子数组
                new int[] { 1, 0, 1 },       // 第二个子数组
                new int[] { 1,1,1 }               // 第三个子数组
                }
        );

        }


    }
}
