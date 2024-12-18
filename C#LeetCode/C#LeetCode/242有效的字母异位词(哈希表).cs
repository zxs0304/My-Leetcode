// FileName：242有效的字母异位词(哈希表).cs
// Author：duole-15
// Date：2024/12/18
// Des：描述
using System;
namespace C_LeetCode
{
    /*242. 有效的字母异位词
给定两个字符串 s 和 t ，编写一个函数来判断 t 是否是 s 的 字母异位词。
输入: s = "anagram", t = "nagaram"
输出: true

输入: s = "rat", t = "car"
输出: false

进阶: 如果输入字符串包含 unicode 字符怎么办？你能否调整你的解法来应对这种情况？
	 */
    public class _242有效的字母异位词_哈希表_
	{
        //类似46.
        //两个字符串是字母异位词，当且仅当它们包含相同的字符，并且字符的出现次数也相同。
        //使用两个数组或字典分别统计s和t中每个字符的数量，然后比较这两个数组是否完全一样。
        //优化：使用一个数组计算s和t中每个字符的出现次数。统计s时 ++ ，统计t时 -- ,最后比较是否全为0即可
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }
            char[] allChar = new char[26];
            for (int i = 0;i<s.Length;i++)
            {
                allChar[s[i] - 'a']++;
                allChar[t[i] - 'a']--;
            }
            for (int i = 0; i < 26; i++)
            {
                if (allChar[i] != 0) return false;
            }
            return true;
        }

    }
}

