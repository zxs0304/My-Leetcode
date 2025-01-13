#include<iostream>
 #include<vector> 
 #include<string>
 #include<map>
 #include<algorithm> 
 using namespace std; 
 /*
 示例1
输入：10  返回值：2
十进制中10的32位二进制表示为0000 0000 0000 0000 0000 0000 0000 1010，其中有两个1。       
输入：-1 返回值：32
负数使用补码表示 ，-1的32位二进制表示为1111 1111 1111 1111 1111 1111 1111 1111，其中32个1
*/ 
    int NumberOf1(int n) 
    {
        int count = 0;
        for(int i = 0;i<32;i++)
        {
            int number = (n >> i) & 1;
            if(number == 1)
            {
                count++;
            }
        }
        return count;


    }

    int NumberOf1_2(int n) 
    {
        int count = 0;
        while (n != 0)
        {
            n &= (n - 1); // 消除最低位的 1 ,例如 11 & 10 = 10 
            count++;
        }
        return count;
    }
int main()
{

}