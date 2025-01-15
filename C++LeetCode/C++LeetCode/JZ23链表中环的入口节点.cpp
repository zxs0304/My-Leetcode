#include<iostream>
 #include<vector> 
 #include<string>
 #include<map>
 #include<algorithm> 
 using namespace std; 
 /*
*/ 
struct ListNode {
    int val;
    struct ListNode *next;
    ListNode(int x) :
        val(x), next(NULL) {
    }
};
        // !!!!!!检查是否有环的标准方法
    ListNode* EntryNodeOfLoop(ListNode* pHead) 
    {
         // 定义快慢指针
        ListNode* slow = pHead;
        ListNode* fast = pHead;

        // !!!!!!检查是否有环的标准方法：
        while(fast != nullptr && fast->next != nullptr)
        {
            // 快指针是满指针的两倍速度
            fast = fast->next->next;
            slow = slow->next;
            // 记录快慢指针第一次相遇的结点
            if(slow == fast) 
                break;
        }
        //出来后有两种情况，
        //1.没有环 ： fast == null 或 fast->next == null
        //2.否则有环
        // 若是快指针指向null，则不存在环
        if (fast == nullptr || fast->next == nullptr) 
        {
            return nullptr;
        }


        // 重新指向链表头部
        slow = pHead;

        while(slow != fast)
        {
            slow = slow->next;
            fast = fast->next;
        }
        return slow;
    }

int main()
{

}
