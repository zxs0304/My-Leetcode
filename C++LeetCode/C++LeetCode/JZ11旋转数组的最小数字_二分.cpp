#include<iostream>
 #include<vector> 
 #include<string>
 #include<map>
 #include<algorithm> 
 using namespace std; 
 /*
 有一个长度为 n 的非降序数组，比如[1,2,3,4,5]，将它进行旋转，即把一个数组最开始的若干个元素搬到数组的末尾，
 变成一个旋转数组，比如变成了[3,4,5,1,2]，或者[4,5,1,2,3]这样的。请问，给定这样一个旋转数组，求数组中的最小值。

*/

    //二分时，不断比较mid 和 right的大小，来缩小边界，具体看题解的图解，很清楚
    int minNumberInRotateArray(vector<int>& nums) 
    {
        int n = nums.size();
        int left = 0;
        int right = n -1;
        //在二分查找算法中，循环的结束条件是 left < right。
        //当这个条件不再满足时，left 和 right 会指向同一个位置，这时，无论返回 left 还是 right，它们的值都是当前找到的最小值。
        while(left < right)
        {
            int mid = left + (right - left)/2 ;
            if(nums[mid] < nums[right])
            {
                // 为什么right不赋值为 mid -1 ，此时nums[mid] < nums[right] ，因此mid的位置有可能是最小值
                right = mid;
            }
            else if(nums[mid] > nums[right])
            {
                left = mid+1;
            }
            else //如果有nums[mid] == nums[right],即数组中存在重复相同的元素 
            {
                //此时最小值可能在左侧，也可能在右侧，甚至可能就是 mid 本身。
                //因此，通过将 right-- ，我们可以确保在下一次迭代中，我们会排除 right 位置的元素，这有助于逐渐缩小搜索范围。
                right--;
            }
        }
        return nums[left];
    }

int main()
{

}