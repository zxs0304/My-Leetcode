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
            最长中毒时间 test = new 最长中毒时间();
            int[] arr = new int[] {1,2 };
            int time = test.CalculatePoisonedTime(arr,5);
            Console.WriteLine(time);
        }


    }
}
