using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _22括号生成_递归_
    {
        public IList<string> GenerateParenthesis(int n)
        {
            IList<string> allStr = new List<string>();
            string curStr = "";
            Digui(0,0,n,curStr,allStr);
            foreach (var str in allStr)
            {
                Console.WriteLine(str);
            }

            return allStr;

        }

        public void Digui(int leftCount , int rightCount , int n ,string curStr, IList<string> allStr)
        {
            if(leftCount == n && rightCount == n)
            {
                allStr.Add(curStr);
                return;
            }

            if (leftCount < n) 
            {
                curStr += "(";
                Digui(leftCount +1,rightCount,n,curStr,allStr);
                curStr = curStr.Remove(curStr.Length - 1);
            }
            if(rightCount < leftCount)
            {
                curStr += ")";
                Digui(leftCount,rightCount+1,n,curStr,allStr);
                curStr = curStr.Remove(curStr.Length - 1);
            }


        }

        //static void Main(string[] args)
        //{
        //    _22括号生成_递归_ s = new _22括号生成_递归_();
        //    s.GenerateParenthesis(3);

        //}

    }
}
