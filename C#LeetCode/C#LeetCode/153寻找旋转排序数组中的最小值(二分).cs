using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _153寻找旋转排序数组中的最小值_二分_
    {
        public int FindMin(int[] nums)
        {
            


            int left = 0;
            int right = nums.Length - 1;



            while (left < right)
            {
                int mid = (left + right) / 2;

                if (nums[left] < nums[right]) //若从left到right整体有序，最小值一定是left处
                {
                    return nums[left];
                }
    
                //走到这说明mid左右两边一半有序，一半无序 ，最小值一定在无序的那一部分
                if (nums[mid] >= nums[left]) //左半部分有序 , 右半部分无序
                {
                    left = mid+1;
                }
                else //右半部分有序
                {
                    right = mid;
                }


            }
            return nums[0];

        }

    }
}
