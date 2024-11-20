using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _131分割回文串_回溯_
    {
        //遍历分割点:从 start 开始，遍历所有可能的结束位置 end，形成子串 s[start:end]。
        //对每个子串，检查它是否是回文.如果当前子串是回文，则将其添加到当前路径 path 中，并递归调用 backtrack，将 end 位置作为新的起始位置。
        //递归返回后，移除最后添加的子串，进行下一次循环，以便尝试其他组合。
        IList<IList<string>> allResult = new List<IList<string>>();
        List<string> curResult = new List<string>();
        public IList<IList<string>> Partition(string s)
        {
            GetPartition(s,0);
            return allResult;
        }
        public void GetPartition(string s ,int start)
        {
            //当start达到字符串的末尾时，说明可以成功分割完所有字符，此时将当前路径 path 添加到结果 result 中。
            if (start == s.Length)
            {
                allResult.Add(new List<string>(curResult));
                return;
            }
            for (int end = start + 1;end <= s.Length;end++ )
            {
                // str 表示从start到 end前一个 的子串
                string str = s.Substring(start,end - start);
                if (IsPalindrome(str))
                {
                    curResult.Add(str);
                    GetPartition(s,end);
                    curResult.RemoveAt(curResult.Count - 1);
                }

            }

        }
        //判断是否是回文串
        public bool IsPalindrome(string s)
        {
            int left = 0;
            int right = s.Length - 1;
            while (left < right)
            {
                if (s[left] != s[right])
                    return false;
                left++;
                right--;
            }
            return true;
        }

    }
}
