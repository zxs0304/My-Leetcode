#include<iostream>
#include<vector> 
#include<string>
#include<map>
#include<algorithm> 
using namespace std;
/*
*/

    //遍历矩阵，让每个位置都作为起始位置开始朝四个方向进行DFS，并且用一个index来记录遍历到了字符串的哪个位置
    // ！！！ 在一次DFS的过程中，已经访问过的字符，要修改为临时字符'#'，以此来标识此字符已经访问过，
    // 以免又回来重复访问
    int rows = 0;
    int cols = 0;
    bool hasPath(vector<vector<char> >& matrix, string word)
    {
        rows = matrix.size();
        cols = matrix[0].size();
        int n = word.size();
        for(int i = 0; i < rows;i++)
        {
            for(int j = 0;j<cols;j++)
            {
                if(DFS(matrix, i, j,word,0))
                {
                    return true;
                }
            }
        }
        return false;
    }

    bool DFS(vector<vector<char> >& matrix,int i , int j ,string& word, int index)
    {
        if(i<0 || i>= rows || j<0 || j>= cols || matrix[i][j] != word[index])
        {
            return false;
        }
        
        if(index == word.size()-1)
        {
            return true;
        }
        else
        {
            char c = matrix[i][j];
            matrix[i][j] = '#';
            bool hasPath = DFS(matrix,i+1,j,word,index+1) || DFS(matrix, i - 1, j, word, index + 1) 
                || DFS(matrix, i, j+1, word, index + 1) || DFS(matrix, i, j-1, word, index + 1);
            matrix[i][j] = c;
            return hasPath;
        }

    }

int main()
{

}