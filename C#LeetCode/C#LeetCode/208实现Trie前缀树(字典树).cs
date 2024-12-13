using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    //其实就是一棵26叉树，每个节点对应一个字符，每个节点下面最多可能有26个子节点，可以用哈希表来存储
    //关键点是利用一个布尔变量isEndOfWord ，来判断当前节点是不是一个单词的结尾。
    public class Trie
    {
        public class TreeNode
        {
            public Dictionary<char, TreeNode> children;
            public bool isEndOfWord;
            public char myChar;//可以不用声明，没有用，不需要存储当前节点所代表的字符
                               // 因为当前节点的字符 已经存在了父节点的children中，且只有父节点用的到当前节点的字符
            public TreeNode(char c)
            {
                myChar = c;
                children = new Dictionary<char, TreeNode>();
            }
        }


        TreeNode root;

        public Trie()
        {
            // 根节点不表示任何字符
            root = new TreeNode(' ');  
        }

        public void Insert(string word)
        {
            TreeNode node = root;
            foreach (char c in word)
            {
                if (!node.children.ContainsKey(c))
                {
                    node.children.Add(c, new TreeNode(c));
                }
                //无论子节点是否含有c，都应该node = node.children[c];
                node = node.children[c];
            }
            // 出循环时，node为word的最后一个字符
            node.isEndOfWord = true;
        }

        public bool Search(string word)
        {
            TreeNode node = root;
            foreach (char c in word)
            {
                if (node.children.ContainsKey(c))
                {
                    node = node.children[c];
                }
                else
                {
                    return false;
                }
            }
            // 出循环时，说明word中的所有字符都在树中，此时node为最后一个字符
            return node.isEndOfWord;
        }

        public bool StartsWith(string prefix)
        {
            TreeNode node = root;
            foreach (char c in prefix)
            {
                if (node.children.ContainsKey(c))
                {
                    node = node.children[c];
                }
                else
                {
                    return false;
                }
            }
            // 出循环时，说明word中的所有字符都在树中
            return true;
        }
    }
}
