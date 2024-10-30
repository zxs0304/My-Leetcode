#include<stdio.h>
#include<string>
#include<vector>
#include <iostream>
using namespace std;

class Solution
{
public:
    bool searchMatrix(vector<vector<int>>& matrix, int target)
    {
        int len1 = matrix.size();//行数
        int len2 = matrix[0].size();//列数
        int left1 = 0,right1 = len1-1; //先在每一行的最后一列使用二分，找到第一个大于等于target的数，此数所在的行也是target的行
        while (left1 <= right1)
        {
            int mid1 = left1 + (right1 - left1) / 2;
            if (matrix[mid1][len2 - 1] < target)
            {
                left1 = mid1+1;
            }
            else if (matrix[mid1][len2 - 1] > target)
            {
                right1 = mid1-1;
            }
            else
            {
                return true;
            }

        }
        if (left1 == len1)//出来以后,left1一定是第一个大于等于target的数的行号,如果每一行的最后一个都比target小，
                          //那么此时left1指向的应该是len1，也就是越界了，此时必须return false，不然下面会报错。但是如果是另一种越界的情况，即所有行的最后一个数都大于target，就不用额外加判断，因为那种情况left1=0，不会报越界的错误
        {
            return false;
        }
        int left2 = 0, right2 = len2 - 1;
        while (left2<=right2)
        {
            int mid2 = left2 + (right2 - left2) / 2;
            if (matrix[left1][mid2] == target)
            {
                return true;
            }
            else if (matrix[left1][mid2] < target)
            {
                left2 = mid2 + 1;
            }
            else 
            {
                right2 = mid2 - 1;
            }

        }

        return false;

    }

    bool MYsearchMatrix(vector<vector<int>>& matrix, int target)
    {
        int len1 = matrix.size();//行数
        int len2 = matrix[0].size();//列数
        int l = 0;
        int r = len1 - 1;
        while (l <= r)
        {
            if (matrix[l][len2 - 1] < target)
            {
                l++;
            }
            else if (matrix[r][0] > target)
            {
                r--;
            }
            else
            {
                int ll = 0, rr = len2 - 1;
                while (ll <= rr)
                {
                    int mid = (ll + rr) / 2;
                    if (matrix[r][mid] == target)
                    {
                        return true;
                    }
                    else if (matrix[r][mid] > target)
                    {
                        rr = mid - 1;
                    }
                    else if (matrix[r][mid] < target)
                    {
                        ll = mid + 1;
                    }
                }
                return false;
            }

        }
        return false;
    }
};