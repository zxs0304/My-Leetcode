#include<iostream>
 #include<vector> 
 #include<string>
 #include<map>
 #include<algorithm> 
 using namespace std; 
 /*
*/ 
    struct ListNode 
    {
        int val;
        struct ListNode *next;
        ListNode(int x) : val(x), next(nullptr) {}
    };

    ListNode* deleteNode(ListNode* head, int val) 
    {
        ListNode* dummy = new ListNode(0);
        dummy->next = head;
        ListNode* cur = dummy;
        while(cur->next != nullptr)
        {
            if(cur->next->val == val)
            {
                cur->next = cur->next->next;
                break;
            }
            cur = cur->next;
        }
        return dummy->next;
    }

int main()
{
    
}