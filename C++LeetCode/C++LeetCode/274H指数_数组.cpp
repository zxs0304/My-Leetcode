#include<iostream>
 #include<vector> 
 #include<string>
 #include<map>
 #include<algorithm> 
 using namespace std; 
 /*274. H 指数
给你一个整数数组 citations ，其中 citations[i] 表示研究者的第 i 篇论文被引用的次数。计算并返回该研究者的 h 指数。
根据维基百科上 h 指数的定义：h 代表“高引用次数” ，一名科研人员的 h 指数 是指他（她）至少发表了 h 篇论文，并且 至少 有 h 篇论文被引用次数大于等于 h 。
如果 h 有多种可能的值，h 指数 是其中最大的那个。
*/ 
    int hIndex(vector<int>& citations) {
        // 从小到大排序
        sort(citations.begin(),citations.end());
        int h = 0; // 初始化当前最大的H指数为最小值
        for(int i = citations.size()-1 ; i >=0 ;i--)
        {
            // 从最后开始向前遍历，一旦有1篇论文引用次数大于当前的最大h指数，那么即表示当前的最大h指数还可以继续增大
            // h最大也不会超过数组的长度，因此不需要管 “至少发表了 h 篇论文”这个条件 
            if(citations[i] > h)
            {
                h++;
            }
        }
        return h;
    }

int main()
{

}