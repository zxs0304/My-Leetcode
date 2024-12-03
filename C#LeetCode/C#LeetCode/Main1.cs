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
            _152乘积最大的子数组_dp_ t = new _152乘积最大的子数组_dp_();

            var result = t.MaxProduct1(new int[] {-4 ,-3,-2});
            Console.WriteLine(result);
        }


    }
}
