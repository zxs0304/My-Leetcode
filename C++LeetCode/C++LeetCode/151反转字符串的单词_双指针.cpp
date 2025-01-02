#include<iostream>
 #include<vector> 
 #include<string>
 #include<map>
 #include<algorithm> 
 using namespace std; 
 /*
*/
    // 两个指针i 和 j，维护每一个单词的末尾，i不断向前，当遍历结束一个单词，就把该单词加到答案中,然后跳过空格直到遇到下一个新的单词，更新j。重复此步骤
    string reverseWords(string s) 
    {
        string result = "";
        int j = s.size()-1;
        while(j>=0 && s[j] == ' ')
        {
            j--;
        }
        int i = j;

        while(i >= 0)
        {
            while(i >= 0 && s[i] != ' ')
            {
                i--;
            }
            result.append(s.substr(i+1,j-i));
            result.append(" ");
            while(i >= 0 && s[i] == ' ')
            {
                i--;
            }
            j = i;
        }
        result.pop_back();
        return result;
        
    }

    
int main()
{

}