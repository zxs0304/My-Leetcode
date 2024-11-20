// FileName：78子集(回溯).cs
// Author：duole-15
// Date：2024/11/20
// Des：描述
using System;
namespace C_LeetCode
{


    public class _78子集_回溯_
	{

        // 全排列需要 for 循环，因为它涉及到元素的顺序和交换，需要遍历每个元素并生成所有可能的排列。
        // 生成子集不需要 for 循环，因为它只需做出选择（包含或不包含当前元素），每个元素的选择是独立的，不依赖于其他元素的顺序。

        //生成子集
        IList<IList<int>> allResult = new List<IList<int>>();
        List<int> curResult = new List<int>();
        public IList<IList<int>> Subsets(int[] nums)
        {
            GetSubsets(nums,0);
            return allResult;
        }
        public void GetSubsets(int[] nums ,int index)
        {
            if (index == nums.Length)
            {
                allResult.Add(new List<int>(curResult));
                return;
            }
            // 这个和全排列不一样，不需要用一个for循环
            curResult.Add(nums[index]);
            GetSubsets(nums, index + 1);
            curResult.RemoveAt(curResult.Count - 1);
            GetSubsets(nums, index + 1);
        }
    }
}

 