#include<iostream>
#include<vector> 
#include<string>
#include<map>
#include<algorithm> 
using namespace std;
/*
*/

    //����������ÿ��λ�ö���Ϊ��ʼλ�ÿ�ʼ���ĸ��������DFS��������һ��index����¼���������ַ������ĸ�λ��
    // ������ ��һ��DFS�Ĺ����У��Ѿ����ʹ����ַ���Ҫ�޸�Ϊ��ʱ�ַ�'#'���Դ�����ʶ���ַ��Ѿ����ʹ���
    // �����ֻ����ظ�����
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