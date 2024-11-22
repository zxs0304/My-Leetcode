using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _22括号生成_递归_
    {

        //if (left < n) 确保我们不会添加超过 n 个左括号。
        //if (right<left) 确保在任何时刻，右括号的数量不会超过左括号的数量，以维持有效的括号组合结构。
        //这两个条件结合在一起，确保了生成的所有括号组合都是有效且符合规则的。
        IList<string> result = new List<string>();
        StringBuilder curStr = new StringBuilder();
        public IList<string> GenerateParenthesis(int n)
        {
            GenerateParenthesis(n, 0, 0);
            return result;
        }
        public void GenerateParenthesis(int n, int left, int right)
        {
            if (left == n && right == n)
            {
                result.Add(curStr.ToString());
                return;
            }

            if (left < n)
            {
                curStr.Append("(");
                GenerateParenthesis(n, left + 1, right);
                curStr.Remove(curStr.Length - 1, 1);

            }
            if (right < left)
            {
                curStr.Append(")");
                GenerateParenthesis(n, left, right + 1);
                curStr.Remove(curStr.Length - 1, 1);
            }

        }

    }
}
