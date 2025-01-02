#include<iostream>
 #include<vector> 
 #include<string>
 #include<map>
 #include<algorithm> 
 using namespace std; 
 /*
*/

// 先push当前字符，再 加或减 flag
 string convert(string s, int numRows)
 {
     if (numRows < 2)
         return s;
     //默认值为空字符串
     vector<string> rows(numRows);
     int i = 0, flag = -1;
     for (char c : s)
     {
         rows[i].push_back(c);
         if (i == 0 || i == numRows - 1)
             flag = -flag;
         i += flag;
     }
     string res;
     //如果不写引用也对，但是是值拷贝，浪费内存
     for (string& row : rows)
         res += row;
     return res;
 }

int main()
{

}