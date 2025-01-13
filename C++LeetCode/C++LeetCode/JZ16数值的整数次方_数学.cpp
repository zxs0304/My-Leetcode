#include<iostream>
 #include<vector> 
 #include<string>
 #include<map>
 #include<algorithm> 
 using namespace std; 
 /*
 实现函数 double Power(double base, int exponent)，求base的exponent次方。 
 注意： 1.保证base和exponent不同时为0。 2.不得使用库函数，同时不需要考虑大数问题 3.有特殊判题，不用考虑小数点后面0的位数。 
 数据范围： ∣ 𝑏 𝑎 𝑠 𝑒 ∣ ≤ 100 ∣base∣≤100 ， ∣ 𝑒 𝑥 𝑝 𝑜 𝑛 𝑒 𝑛 𝑡 ∣ ≤ 100 ∣exponent∣≤100 ,
 保证最终结果一定满足 ∣ 𝑣 𝑎 𝑙 ∣ ≤ 1 0 4 ∣val∣≤10 4 进阶：空间复杂度 𝑂 ( 1 ) O(1) ，
 时间复杂度 𝑂 ( 𝑛 ) O(n) 
 示例1 输入： 2.00000,3 返回值： 8.00000  
 示例2 输入： 2.10000,3  返回值： 9.26100 
 示例3 输入： 2.00000,-2  返回值： 0.25000 
 说明： 2的-2次方等于1/4=0.25
*/ 

    double Power(double base, int exponent) 
    {
        //起始值应该设为1
        double result = 1;
        for(int i = 0;i<abs(exponent);i++)
        {
            result *= base;
        }
        return exponent >= 0 ? result : 1/result;
    }

int main()
{

}