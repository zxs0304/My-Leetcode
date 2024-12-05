// FileName：287寻找重复数(技巧).cs
// Author：duole-15
// Date：2024/12/5
// Des：描述
using System;
namespace C_LeetCode
{
    /*287. 寻找重复数
给定一个包含 n + 1 个整数的数组 nums ，其数字都在 [1, n] 范围内（包括 1 和 n），可知至少存在一个重复的整数。
假设 nums 只有 一个重复的整数 ，返回 这个重复的数 。
你设计的解决方案必须 不修改 数组 nums 且只用常量级 O(1) 的额外空间。
输入：nums = [1,3,4,2,2]
输出：2
输入：nums = [3,1,3,4,2]
输出：3
输入：nums = [3,3,3,3,3]
输出：3

方法一：二分查找
我们定义 cnt[i] 表示 nums 数组中小于等于 i 的数有多少个，假设我们重复的数是 target，那么 [1,target−1]里的所有数满足 cnt[i]≤i，[target,n] 里的所有数满足 cnt[i]>i，具有单调性。
以示例 1 为例，我们列出每个数字的 cnt 值：
nums	1	2	3	4
cnt	    1	3	4	5
示例中重复的整数是 2，我们可以看到 [1,1] 中的数满足 cnt[i]≤i，[2,4] 中的数满足 cnt[i]>i 。
如果知道 cnt[] 数组随数字 i 逐渐增大具有单调性（即 target 前 cnt[i]≤i，target 后 cnt[i]>i），那么我们就可以直接利用二分查找来找到重复的数。
但这个性质一定是正确的吗？考虑 nums 数组一共有 n+1 个位置，我们填入的数字都在 [1,n] 间，有且只有一个数重复放了两次以上。对于所有测试用例，考虑以下两种情况：

如果测试用例的数组中 target 出现了两次，其余的数各出现了一次，这个时候肯定满足上文提及的性质，因为小于 target 的数 i 满足 cnt[i]=i，大于等于 target 的数 j 满足 cnt[j]=j+1。

如果测试用例的数组中 target 出现了三次及以上，那么必然有一些数不在 nums 数组中了，这个时候相当于我们用 target 去替换了这些数，我们考虑替换的时候对 cnt[] 数组的影响。如果替换的数 i 小于 target ，那么 [i,target−1] 的 cnt 值均减一，其他不变，满足条件。如果替换的数 j 大于等于 target，那么 [target,j−1] 的 cnt 值均加一，其他不变，亦满足条件。

因此我们生成的数组一定具有上述性质的。

	 */
    public class _87寻找重复数_技巧_
	{
        public int FindDuplicate(int[] nums)
        {
            int n = nums.Length;
            for (int i = 0;i<n;i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        return nums[i];
                    }
                }
            }
            return nums[0];
        }
    }
}

