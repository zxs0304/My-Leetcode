
using System;
namespace C_LeetCode
{
    /*763. 划分字母区间
给你一个字符串 s 。我们要把这个字符串划分为尽可能多的片段，同一字母最多出现在一个片段中。
注意，划分结果需要满足：将所有划分结果按顺序连接，得到的字符串仍然是 s 。
返回一个表示每个字符串片段的长度的列表。
示例 1：
输入：s = "ababcbacadefegdehijhklij"
输出：[9,7,8]
划分结果为 "ababcbaca"、"defegde"、"hijhklij" 。
每个字母最多出现在一个片段中。
像 "ababcbacadefegde", "hijhklij" 这样的划分是错误的，因为划分的片段数较少。 
示例 2：
输入：s = "eccbbbbdec"
输出：[10]

	 */

    public class _763划分字母区间
	{
        // 不想用LastIndexOf的话，就建一个int[26]存储每一种字符最后一次出现的下标 
        public IList<int> PartitionLabels(string s)
        {
            IList<int> result = new List<int>();
            int start = 0;
            while (start < s.Length)
            {
                // 设置这一段的初始结束位置
                int end = s.LastIndexOf(s[start]);
                for (int i = start; i < end; i++)
                {
                    // 不断更新这一段的结束位置
                    int j = s.LastIndexOf(s[i]);
                    end = Math.Max(end, j);
                }
                // 这一段结束，记录长度
                result.Add(end - start + 1);
                // 更新下一段的开始位置
                start = end + 1;
            }
            return result;
        }
    }
}

