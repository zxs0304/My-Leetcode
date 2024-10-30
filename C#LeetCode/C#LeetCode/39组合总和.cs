using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution39
{
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        IList<IList<int>> result = new List<IList<int>>();
        List<int> curResult = new List<int>();
        DiGui(candidates,target,0,result, curResult);
        return result;
    }

    public void DiGui(int[] candidates,int target,int index, IList<IList<int>> result,List<int>curResult)
    {
        if(target == 0)
        {
            result.Add(new List<int>(curResult));
            return;
        }
        else if(target < 0)
        {
            return;
        }

        for(int i = index; i < candidates.Length; i++)
        {
            curResult.Add(candidates[i]);
            DiGui(candidates,target - candidates[i],i,result,curResult); //注意i，不要传参为index，index是这一层开始的位置
            curResult.Remove(candidates[i]);
        }
    }

}