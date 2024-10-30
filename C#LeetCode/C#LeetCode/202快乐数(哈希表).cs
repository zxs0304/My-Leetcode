using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _202快乐数_哈希表_
    {
        public bool IsHappy(int n)
        {
            HashSet<int> list = new HashSet<int>();

            while (true)
            {

                int sum = 0;
                while (n > 0)
                {
                    int m = n % 10;
                    n /= 10;
                    sum += (int)Math.Pow(m, 2);
                }
                if (sum == 1)
                {
                    return true;
                }
                else
                {
                    if (list.Contains(sum))
                    {
                        return false;
                    }
                    else
                    {
                        list.Add(sum);
                    }

                }

                n = sum;

            }
            

        }

        public bool IsHappy2(int n)
        {
            int slow = n;
            int fast = GetNext(n);
            while (true)
            {

                if (fast == 1)
                {
                    return true;
                }

                if (slow == fast)
                {
                    return false;
                }

                slow = GetNext(slow);
                fast = GetNext(GetNext(fast));
            }


        }

        public int GetNext(int curSum)
        {
            int nextSum = 0;
            while (curSum > 0)
            {
                int number = curSum % 10;
                curSum /= 10;
                nextSum += (int)Math.Pow(number, 2);
            }
            return nextSum;

        }

    }
}
