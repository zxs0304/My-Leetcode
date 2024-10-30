using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _88合并两个有序数组
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int i = m-1;
            int j = n-1;
            int cur = nums1.Length - 1;
            while (i>=0 && j >=0)
            {
                if (nums1[i] > nums2[j])
                {
                    nums1[cur] = nums1[i];
                    i--;
                }
                else
                {
                    nums1[cur] = nums2[j];
                    j--;
                }
                cur--;
            }

            // 只需要处理 nums2 的剩余部分
            while (j >= 0)
            {
                nums1[cur] = nums2[j];
                j--;
                cur--;
            }

        }
    }
}
