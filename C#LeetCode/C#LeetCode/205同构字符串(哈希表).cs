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

        //290.290. 单词规律
        //给定一种规律 pattern 和一个字符串 s ，判断 s 是否遵循相同的规律。
        //这里的 遵循 指完全匹配，例如， pattern 里的每个字母和字符串 s 中的每个非空单词之间存在着双向连接的对应规律。
        //与205.几乎一样，都是双向映射，唯一不同是字符与字符串之间的映射。另外需要多加一个长度一致的条件
        public bool WordPattern(string pattern, string s)
        {
            // 将字符串 s 按空格分割成单词数组
            string[] words = s.Split(' ');

            // !!!如果模式的长度与单词的数量不一致，直接返回 false
            if (pattern.Length != words.Length)
            {
                return false;
            }

            // 创建两个字典来存储模式字符和单词之间的映射
            Dictionary<char, string> charToWord = new Dictionary<char, string>();
            Dictionary<string, char> wordToChar = new Dictionary<string, char>();

            for (int i = 0; i < pattern.Length; i++)
            {

                char currentChar = pattern[i];
                string currentWord = words[i];
                // 检查当前字符是否已存在于字典中
                if (!charToWord.ContainsKey(currentChar))
                {
                    // 如果不存在，添加到字典中
                    charToWord[currentChar] = currentWord;

                }
                else
                {
                    // 如果已存在且映射的单词不匹配，返回 false
                    if (charToWord[currentChar] != currentWord)
                    {
                        return false;
                    }
                }

                // 检查当前字符是否已存在于字典中
                if (!wordToChar.ContainsKey(currentWord))
                {
                    // 如果不存在，添加到字典中
                    wordToChar[currentWord] = currentChar;

                }
                else
                {
                    // 如果已存在且映射的单词不匹配，返回 false
                    if (wordToChar[currentWord] != currentChar)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

    }
}

