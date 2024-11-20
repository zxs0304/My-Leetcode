using System.Collections;
using System.Collections.Generic;
public class TEST
{
    // 全排列需要 for 循环，因为它涉及到元素的顺序和交换，需要遍历每个元素并生成所有可能的排列。
    // 生成子集不需要 for 循环，因为它只需做出选择（包含或不包含当前元素），每个元素的选择是独立的，不依赖于其他元素的顺序。

    // 全排列
    IList<IList<int>> allResults = new List<IList<int>>();
    public IList<IList<int>> Permute(int[] nums)
    {
        GetPermute(nums, 0);
        return allResults;
    }

    public void GetPermute(int[] nums, int index)
    {
        if (index == nums.Length)
        {
            allResults.Add(new List<int>(nums));
            return;
        }
        for (int i = index; i < nums.Length; i++)
        {
            Swap(nums, index, i);
            // 不能传index++ 因为会修改当前index的值，等会换回来就错了
            GetPermute(nums, index + 1);
            Swap(nums, index, i);
        }
    }
    public void Swap(int[] nums, int i, int j)
    {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }

}
