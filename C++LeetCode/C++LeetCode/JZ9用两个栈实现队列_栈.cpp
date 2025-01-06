#include<iostream>
 #include<vector> 
 #include<string>
  #include<stack>
 #include<map>
 #include<algorithm> 
 using namespace std; 
 /*
*/ 

    stack<int> stack1;
    stack<int> stack2;
    
    void push(int node) 
    {
        stack1.push(node);
    }
    
    int pop() 
    {
        if(stack2.empty())
        {
            while(!stack1.empty())
            {
                int temp = stack1.top();
                stack1.pop();
                stack2.push(temp);
            }
        }
        int number = stack2.top();
        stack2.pop();
        return number;
    }


 
int main()
{

}