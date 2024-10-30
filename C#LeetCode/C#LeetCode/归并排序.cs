using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class 归并排序
    {
        public void GuiBingPaiXu(int[] nums)
        {
            int n = nums.Length;
            int[] help = new int[n]; //辅助数组
            Sort(nums,0,n-1,help);
            //foreach (int item in nums)
            //{
            //    Console.WriteLine(item);
            //}

        }

        public void Sort(int[] nums,int l , int r, int[] help)
        {
            if (l == r)
            {
                return;
            }
            int mid = (l + r) / 2;
            Sort(nums,l,mid,help);
            Sort(nums,mid+1,r,help);
            Merge(nums,l,mid,r,help);

          
        }

        public void Merge(int[] nums , int l ,int mid, int r, int[] help ) //必须要传mid
        {
            int i = l;
            int j = mid + 1;
            int helpIndex = l;
            while (i<=mid && j <= r)
            {
                if (nums[i] < nums[j])
                {
                    help[helpIndex] = nums[i];
                    i++;
                }
                else
                {
                    help[helpIndex] = nums[j];
                    j++;
                }

                helpIndex++;
            }

            //出来后，有一个数组具有剩余
            while (i<=mid)
            {
                help[helpIndex] = nums[i];
                i++;
                helpIndex++;
            }
            while (j <= r)
            {
                help[helpIndex] = nums[j];
                j++;
                helpIndex++;
            }

            //最后把辅助数组中有序的序列刷回到原数组
            for (;l <= r;l++)
            {
                nums[l] = help[l];

            }

        }


    }
}
