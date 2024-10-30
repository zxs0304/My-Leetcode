using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class 快速排序
    {

        public void KuaiSuPaiXu(int[] nums)
        {
            Sort(0, nums.Length - 1,nums);
            //foreach (int i in nums)
            //{
            //    Console.WriteLine(i);
            //}

        }

        public void Sort(int start , int end, int[] nums)
        {
            if (start >= end)
            {
                return;
            }

            int baseValue = nums[start];
            int l = start;
            int r = end;

            while (l < r )
            {
                while (nums[r] > baseValue && l < r)
                {
                    r--;
                }
                while (nums[l] < baseValue && l < r)
                {
                    l++;
                }

                if (l < r) // 只有在 l < r 时才进行交换 , l==r时不交换
                {
                    Swap(l, r, nums);
                }


            }

            Swap( start,l,nums); //此时l和r都执行基准值的坐标
            int baseIndex = l; 

            Sort(start , baseIndex - 1,nums);
            Sort(baseIndex + 1, end,nums);

        }

        public void Swap(int i , int k , int[] nums)
        {
            int temp = nums[i];
            nums[i] = nums[k];
            nums[k] = temp;
        }



    }
}
