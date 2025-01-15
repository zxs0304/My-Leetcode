#include<iostream>
 #include<vector> 
 #include<string>
 #include<map>
 #include<algorithm> 
 using namespace std; 
 /*
 输入一个长度为 n 整数数组，实现一个函数来调整该数组中数字的顺序，使得所有的奇数位于数组的前面部分，所有的偶数位于数组的后面部分，并保证奇数和奇数，偶数和偶数之间的相对位置不变。
*/ 

    //比较好想的是新建两个数组再合并，
    //另一种是时间O(n2) 空间O(1)
    //遍历数组的每个元素，索引为 i。如果当前元素是奇数，则从该数开始，向前遍历。如果前一个元素是偶数，则进行交换。
    vector<int> reOrderArray(vector<int>& array) 
    {
        int n = array.size();
        for (int i = 0; i < n; i++) // 遍历数组
        {
            if (array[i] % 2 == 1) // 检查当前元素是否为奇数
            {
                // 如果是奇数，将其移动到前面
                int j = i; // 保存当前索引
                while (j > 0 && array[j - 1] % 2 == 0) // 如果前一个数是偶数
                {
                    // 交换当前位置的元素和前一个位置的元素
                    int temp = array[j];
                    array[j] = array[j - 1];
                    array[j - 1] = temp;
                    j--; // 移动到前一个位置
                }
            }
        }
        return array;
    }
    
int main()
{

}