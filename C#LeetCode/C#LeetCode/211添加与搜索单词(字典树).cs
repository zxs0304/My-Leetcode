// FileName：211添加与搜索单词(字典树).cs
// Author：duole-15
// Date：2024/12/14
// Des：描述
using System;
namespace C_LeetCode
{

    /*211. 添加与搜索单词 - 数据结构设计
请你设计一个数据结构，支持 添加新单词 和 查找字符串是否与任何先前添加的字符串匹配.实现词典类 WordDictionary ：
WordDictionary() 初始化词典对象
void addWord(word) 将 word 添加到数据结构中，之后可以对它进行匹配
bool search(word) 如果数据结构中存在字符串与 word 匹配，则返回 true ；否则，返回  false 。word 中可能包含一些 '.' ，每个 . 都可以表示任何一个字母。
输入：
["WordDictionary","addWord","addWord","addWord","search","search","search","search"]
[[],["bad"],["dad"],["mad"],["pad"],["bad"],[".ad"],["b.."]]
输出：
[null,null,null,null,false,true,true,true]
解释：
WordDictionary wordDictionary = new WordDictionary();
wordDictionary.addWord("bad");
wordDictionary.addWord("dad");
wordDictionary.addWord("mad");
wordDictionary.search("pad"); // 返回 False
wordDictionary.search("bad"); // 返回 True
wordDictionary.search(".ad"); // 返回 True
wordDictionary.search("b.."); // 返回 True
	 */
    public class WordDictionary
    {
        public class TreeNode
        {
            public Dictionary<char, TreeNode> children;
            public bool isEndOfWord;

            public TreeNode()
            {
                children = new Dictionary<char, TreeNode>();
            }
        }

        TreeNode root;
        public WordDictionary()
        {
            root = new TreeNode();
        }

        public void AddWord(string word)
        {
            TreeNode node = root;
            foreach (char c in word)
            {
                if (!node.children.ContainsKey(c))
                {
                    node.children.Add(c, new TreeNode());
                }
                //无论子节点是否含有c，都应该node = node.children[c];
                node = node.children[c];
            }
            // 出循环时，node为word的最后一个字符
            node.isEndOfWord = true;
        }

        public bool Search(string word)
        {
            return Search(word,0,root);
        }

        // 递归搜索方法。 ！！！！ 关键点在于使用一个index来记录当前遍历的位置
        public bool Search(string word, int index ,TreeNode node)
        {
            int n = word.Length;

            // 如果索引到达单词末尾，检查当前节点是否为单词结束
            if (index == n)
            {
                return node.isEndOfWord;
            }
            
            if (word[index] != '.')
            {
                // 如果当前字符在子节点中存在
                if (node.children.ContainsKey(word[index]))
                {
                    // 移动到对应的子节点，并递归搜索下一个字符
                    node = node.children[word[index]];
                    return Search(word, index + 1, node);
                }
            }
            else 
            {
                // 当前字符为 '.', 要遍历所有子节点，
                foreach (var childNode in node.children.Values)
                {
                    // 只要有一个子节点返回true，就说明包含这个单词,直接返回true即可
                    if (Search(word, index + 1, childNode))
                    {
                        return true;
                    }
                }

            }

            return false;
        }

    }
}

