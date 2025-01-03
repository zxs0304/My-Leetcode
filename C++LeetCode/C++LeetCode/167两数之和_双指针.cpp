#include<iostream>
 #include<vector> 
 #include<string>
 #include<map>
 #include<algorithm> 
 using namespace std; 
 /*
 给你一个下标从 1 开始的整数数组 numbers ，该数组已按 非递减顺序排列  ，
请你从数组中找出满足相加之和等于目标数 target 的两个数。如果设这两个数分别是 numbers[index1] 和 numbers[index2] ，则 1 <= index1 < index2 <= numbers.length 。
以长度为 2 的整数数组 [index1, index2] 的形式返回这两个整数的下标 index1 和 index2。
你可以假设每个输入 只对应唯一的答案 ，而且你 不可以 重复使用相同的元素。你所设计的解决方案必须只使用常量级的额外空间。

输入：numbers = [2,7,11,15], target = 9
输出：[1,2]
解释：2 与 7 之和等于目标数 9 。因此 index1 = 1, index2 = 2 。返回 [1, 2] 。

输入：numbers = [2,3,4], target = 6
输出：[1,3]
解释：2 与 4 之和等于目标数 6 。因此 index1 = 1, index2 = 3 。返回 [1, 3] 。

输入：numbers = [-1,0], target = -1
输出：[1,2]
解释：-1 与 0 之和等于目标数 -1 。因此 index1 = 1, index2 = 2 。返回 [1, 2] 。
*/ 

    //利用有序性 和 一定有唯一解，i指向头，j指向尾，然后直接判断当前的和，与target相比较，根据大小情况来判断移动i或是j
    vector<int> twoSum(vector<int>& numbers, int target) 
    {
        int n = numbers.size();
        int i = 0;
        int j = n-1;
        while(i <= j)
        {
            if(numbers[i] + numbers[j] == target)
            {
                return vector<int>{i+1,j+1};
            }
            else if(numbers[i] + numbers[j] < target)
            {
                i++;
            }
            else
            {
                j--;
            }
        }
        return vector<int>();

    }
   

    // 二分法，定一个数，然后找另一个target
    // while(left <= right)的情况，出来时，left是第一个大于target的数，right是第一个小于target的，可能会越界
    vector<int> twoSum_2(vector<int>& numbers, int target) 
    {
        int n = numbers.size();
        for(int i = 0;i<n;i++)
        {
            int number2 = target - numbers[i];
            int left = i+1;
            int right = n - 1;
            while(left <= right)
            {
                int mid = (left + right)/2;
                if(numbers[mid] == number2)
                {
                    return vector<int>{i+1,mid+1};
                }
                else if(numbers[mid] < number2)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

        }
        return vector<int>();

    }

int main()
{

}