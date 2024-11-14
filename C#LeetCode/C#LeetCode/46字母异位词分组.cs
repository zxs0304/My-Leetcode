

using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C_LeetCode
{
    // 哈希表统计每个字母的出现次数，出现次数一样的，即为异位词
    internal class _46字母异位词分组
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string,List<string>> results = new Dictionary<string,List<string>>();
            int[] count = new int[26];//用来记录每个字母的出现次数
            foreach (string str in strs)
            {
                Array.Fill(count, 0);
                foreach (char c in str)
                {
                    count[c-'a']++;
                }
                StringBuilder sb = new StringBuilder();
                for (int i=0;i<26;i++)
                {
                    if (count[i] != 0)
                    {
                        sb.Append((char)('a' + i));
                        sb.Append(count[i]);
                    }
                }

                string key = sb.ToString();
                if (results.ContainsKey(key))
                {
                }
                else
                {
                    results[key] = new List<string>();
                }
                results[key].Add(str);
            }
            //foreach (var item in results)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach (string str in item.Value)
            //    {
                    
            //        Console.Write(str + " ");
            //    }
            //    Console.WriteLine(" = ");
            //}
            return new List<IList<string>>(results.Values);

        }

    }
}
