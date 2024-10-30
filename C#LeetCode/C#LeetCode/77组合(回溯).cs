using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

public class Solution
{
    public IList<IList<int>> Combine(int n, int k)
    {
        IList<int> currentNumbers = new List<int>();
        IList<IList<int>> allNumbers = new List<IList<int>>();

        DiGui(currentNumbers, k, allNumbers,n,1);
        return allNumbers;
    }

    public void DiGui(IList<int> currentNumbers,int k, IList<IList<int>> allNumbers,int n,int index)
    {

        if (currentNumbers.Count == k)
        {
            allNumbers.Add(new List<int>(currentNumbers));
            return;
        }

        for (int i = index; i <= n; i++)
        {
            currentNumbers.Add(i);

            DiGui(currentNumbers, k, allNumbers, n, i + 1);


            currentNumbers.Remove(i);

        }

    }

    //static void Main(string[] args)
    //{
    //    Solution s = new Solution();
    //    var arrs =  s.Combine(4,2);
    //    foreach(var item in arrs)
    //    {
    //        foreach(var i in item)
    //        {
    //            Console.Write(i);
    //        }

    //        Console.WriteLine();
    //    }
    //}

}