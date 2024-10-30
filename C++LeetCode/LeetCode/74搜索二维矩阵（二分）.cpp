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
        int len1 = matrix.size();//����
        int len2 = matrix[0].size();//����
        int left1 = 0,right1 = len1-1; //����ÿһ�е����һ��ʹ�ö��֣��ҵ���һ�����ڵ���target�������������ڵ���Ҳ��target����
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
        if (left1 == len1)//�����Ժ�,left1һ���ǵ�һ�����ڵ���target�������к�,���ÿһ�е����һ������targetС��
                          //��ô��ʱleft1ָ���Ӧ����len1��Ҳ����Խ���ˣ���ʱ����return false����Ȼ����ᱨ�������������һ��Խ���������������е����һ����������target���Ͳ��ö�����жϣ���Ϊ�������left1=0�����ᱨԽ��Ĵ���
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
        int len1 = matrix.size();//����
        int len2 = matrix[0].size();//����
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