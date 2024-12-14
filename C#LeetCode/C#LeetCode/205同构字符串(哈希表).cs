// FileName：205同构字符串(哈希表).cs
// Author：duole-15
// Date：2024/12/14
// Des：描述
using System;
namespace C_LeetCode
{
    /*205. 同构字符串
给定两个字符串 s 和 t ，判断它们是否是同构的。如果 s 中的字符可以按某种映射关系替换得到 t ，那么这两个字符串是同构的。
每个出现的字符都应当映射到另一个字符，同时不改变字符的顺序。不同字符不能映射到同一个字符上，相同字符只能映射到同一个字符上，字符可以映射到自己本身。

输入：s = "egg", t = "add"
输出：true

输入：s = "foo", t = "bar"
输出：false

输入：s = "paper", t = "title"
输出：true
	 */
    public class _205同构字符串_哈希表_
	{
        // 由于不同字符不能映射到同一个字符上，相同字符只能映射到同一个字符上
        // 所以需要双向一对一映射 ：即字符 s 中的每个字符必须映射到 t 中的一个字符 。反之，t 中的每个字符也必须唯一地映射到 s 中的某个字符。
        // 因此需要两个字典，分别记录，s到t的映射，和t到s的映射，最终
        public bool IsIsomorphic(string s, string t)
        {
            Dictionary<char, char> s2t = new();
            Dictionary<char, char> t2s = new();
            for (int i = 0; i < s.Length; i++)
            {
                char charS = s[i];
                char charT = t[i];

                if (!s2t.ContainsKey(charS))
                {
                    s2t.Add(charS, charT);
                }
                else
                {
                    // charS已经被映射到了其他的字符
                    if (s2t[charS] != charT)
                    {
                        return false; // 不同的字符不能映射到同一个字符
                    }
                }

                if (!t2s.ContainsKey(charT))
                {
                    t2s.Add(charT, charS);
                }
                else
                {
                    if (t2s[charT] != charS)
                    {
                        return false; 
                    }
                }
            }

            return true;
        }
    }
}

