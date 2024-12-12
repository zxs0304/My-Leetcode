using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    public delegate void myAction();
    class Person2
    {
        public myAction action;

        public void SetMyAction(myAction a)
        {
            action = a;
        }

    }

    class Person1
    {
        public void MyPrint()
        {
            Console.WriteLine("Person1的函数");
        }

        public static void Main(string[] args)
        {
            Person1 person1 = new Person1();
            Person2 person2 = new Person2();
            person2.SetMyAction(person1.MyPrint);
            person2.action.Invoke();
            

            //_152乘积最大的子数组_dp_ t = new _152乘积最大的子数组_dp_();

            //var result = t.MaxProduct1(new int[] {-4 ,-3,-2});
            //Console.WriteLine(result);
        }
    }
}
