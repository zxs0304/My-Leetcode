#include<iostream>
 #include<vector> 
 #include<string>
 #include<map>
 #include<algorithm> 
 using namespace std; 
 /*
*/ 

struct TreeNode 
{
	int val;
 	struct TreeNode *left;
 	struct TreeNode *right;
 	TreeNode(int x) : val(x), left(nullptr), right(nullptr) {}
};

    TreeNode* reConstructBinaryTree(vector<int>& preOrder, vector<int>& vinOrder) 
    {
        return DFS(preOrder,vinOrder,0, preOrder.size()-1,0,vinOrder.size()-1);
    }
    TreeNode* buildTree(vector<int>& preorder, vector<int>& inorder) 
    {
        return DFS(preorder,inorder,0, preorder.size()-1,0,inorder.size()-1);
    }

    TreeNode* DFS(vector<int>& preOrder, vector<int>& vinOrder,int preLeft,int preRight,int inLeft,int inRight) 
    {
        if(preLeft > preRight || inLeft > inRight)
        {
            return nullptr;
        }
        TreeNode* root = new TreeNode(preOrder[preLeft]);
        vector<int>::iterator it = find(vinOrder.begin(),vinOrder.end(),preOrder[preLeft]);
        int InRootIndex = distance(vinOrder.begin(),it);
        
        root->left = DFS(preOrder , vinOrder , preLeft +1 , preLeft + (InRootIndex - inLeft) , inLeft , InRootIndex - 1);
        root->right = DFS(preOrder,vinOrder,preLeft + (InRootIndex - inLeft) + 1  ,preRight , InRootIndex + 1,inRight);
        return root;
    }


int main()
{

}