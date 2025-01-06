#include<iostream>
 #include<vector> 
 #include<string>
 #include<map>
 #include<algorithm> 
 using namespace std; 
 /*
 给定一个二叉树其中的一个结点，请找出中序遍历顺序的下一个结点并且返回。
 注意，树中的结点不仅包含左右子结点，同时包含指向父结点的next指针。下图为一棵有9个节点的二叉树。树中从父节点指向子节点的指针用实线表示，从子节点指向父节点的用虚线表示

输入:{8,6,10,5,7,9,11},8
返回:9
解析:这个组装传入的子树根节点，其实就是整颗树，
中序遍历{5,6,7,8,9,10,11}，根节点8的下一个节点就是9，应该返回{9,10,11}，
后台只打印子树的下一个节点，所以只会打印9，如下图，其实都有指向左右孩子的指针，还有指向父节点的指针，下图没有画出来
*/

struct TreeLinkNode {
    int val;
    struct TreeLinkNode *left;
    struct TreeLinkNode *right;
    struct TreeLinkNode *next;
    TreeLinkNode(int x) :val(x), left(NULL), right(NULL), next(NULL) {
        
    }
};
    // 法一 先一直向上递归找到根节点，然后从根节点开始，进行一次中序遍历，在中序遍历的过程中，维护两个变量，
    //分别记录中序遍历时 当前节点的上一个节点preNode  和  要找的目标节点targetNode。 当遍历过程中，当前节点的上一个节点等于要找的节点时，就记录当前节点为targetNode

    // 记录中序遍历中上一个节点
    TreeLinkNode* preNode = nullptr;
    // 在中序遍历过程中，记录要找的节点
    TreeLinkNode* targetNode = nullptr;
    TreeLinkNode* GetNext(TreeLinkNode* pNode) 
    {
        TreeLinkNode* root = GetRoot(pNode);
        DFS(root,pNode); 
        return targetNode;
    }
    void DFS(TreeLinkNode* root,TreeLinkNode* target) 
    {
        if(root->left != nullptr)
        {
            DFS(root->left,target);
        }

        if(preNode != nullptr && preNode == target)
        {
            targetNode = root;
        }

        preNode = root;
        
        if(root->right != nullptr)
        {
            DFS(root->right,target);
        }
    }
    TreeLinkNode* GetRoot(TreeLinkNode* target) 
    {
        if(target->next != nullptr)
            return GetRoot(target->next);
        else
            return target;
    }


    // 法二.
    //有右子树的情况：如果节点 当前节点 有右子树，则后继节点是右子树中的最左节点。
    //无右子树的情况:
    // 如果当前节点没有右子树，意味着在当前节点的右侧没有任何节点。那么后继节点可能在其祖宗节点的某个位置。
    //我们获取当前节点的父节点，然后检查 当前节点 是否为其父节点的右子节点。
    // 如果是右子节点，说明其父节点已经遍历过了，其父节点不可能是后继节点 ,后继节点只可能在更上层的节点中。
    //我们继续向上查找，直到找到一个节点，它是其父节点的左子节点。这个节点的父节点就是我们要找的后继节点。
    TreeLinkNode* GetNext_2(TreeLinkNode* curNode) 
    {
        // 如果当前节点为空，直接返回空
        if (curNode == nullptr) return nullptr;

        // 如果当前节点有右子树
        if (curNode->right != nullptr) {
            // 找到右子树中的最左节点
            TreeLinkNode* node = curNode->right;
            while (node->left != nullptr) {
                node = node->left;
            }
            // 返回最左节点，即为当前节点的后继节点
            return node;
        }

        // 如果当前节点没有右子树，则向上寻找后继
        TreeLinkNode* parent = curNode->next; // 获取当前节点的父节点
        // 当当前节点是父节点的右子节点时，继续向上寻找
        while (parent != nullptr && curNode == parent->right) {
            curNode = parent;      // 将当前节点移动到父节点
            parent = parent->next; // 更新父节点
        }
        // 返回找到的后继节点（可能是父节点）
        return parent;
}


int main()
{

}