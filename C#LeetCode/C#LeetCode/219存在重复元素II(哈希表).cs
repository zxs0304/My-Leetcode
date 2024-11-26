
namespace C_LeetCode
{
    /*219. 存在重复元素 II
给你一个整数数组 nums 和一个整数 k ，判断数组中是否存在两个 不同的索引 i 和 j ，满足 nums[i] == nums[j] 且 abs(i - j) <= k 。如果存在，返回 true ；否则，返回 false 。
输入：nums = [1,2,3,1], k = 3
输出：true
输入：nums = [1,0,1,1], k = 1
输出：true
输入：nums = [1,2,3,1,2,3], k = 2
输出：false

	 */
    public class _219存在重复元素II_哈希表_
	{
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            // 键是元素，值是最近一次出现的位置
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dic.ContainsKey(nums[i]))
                {
                    dic.Add(nums[i], i);
                }
                else
                {
                    int preIndex = dic[nums[i]];
                    if (i - preIndex <= k)
                    {
                        return true;
                    }
                    // 更新最近一次出现的位置
                    dic[nums[i]] = i;
                }
            }
            return false;
        }
    }
}

