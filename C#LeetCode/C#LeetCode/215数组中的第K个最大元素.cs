using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    class _215数组中的第K个最大元素
    {
        public int FindKthLargest(int[] nums, int k)
        {
            int n = nums.Length;
            int left = 0; 
            int right = n - 1;
            return DiGui(nums,0,right,nums.Length - k);

        }

        public int DiGui(int[] nums , int left , int right ,int k)
        {

            int baseValue = nums[right]; //选最右边的数作为基准值
            int midIndex = left; //midIndex表示的是 即midIndex左边的数都小于基准值
            for (int i = midIndex; i < right; i++)
            {
                if (nums[i] < baseValue)
                {
                    Swap(nums, i, midIndex);
                    midIndex++;
  
                }
            }
            Swap(nums, right, midIndex);

            if(midIndex == k)
            {
                return nums[midIndex];
            }
            else if(midIndex < k)
            {
                return DiGui(nums,midIndex+1,right,k);
            }
            else
            {
                return DiGui(nums,left,midIndex-1,k);
            }


        }

        public void Swap(int[] nums , int i , int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;

        }
    }
}
