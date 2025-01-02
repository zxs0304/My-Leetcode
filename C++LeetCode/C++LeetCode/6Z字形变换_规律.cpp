#include<iostream>
 #include<vector> 
 #include<string>
 #include<map>
 #include<algorithm> 
 using namespace std; 
 /*
*/

    string convert(string s, int numRows) 
    {
        vector<vector<char>> result(numRows);
        int dir = -1;
        int rowIndex = 0;
        for(int i = 0;i<s.size();i++)
        {
            if(rowIndex == 0 || rowIndex == numRows-1)
            {
                dir = -dir;
            }

            result[rowIndex].push_back(s[i]);

            rowIndex += dir;
        }
        string newStr ="";
        // 按顺序遍历二维 vector
        for (int i = 0; i < result.size(); ++i) 
        { // 遍历行
            for (int j = 0; j < result[i].size(); ++j) 
            { // 遍历列
                newStr += result[i][j];
            }
        }
    }

int main()
{

}