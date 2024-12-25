#include<iostream>
 #include<vector> 
 #include<string>
 #include<map>
 #include<algorithm> 
 using namespace std; 
 /*
 实现RandomizedSet 类：
RandomizedSet() 初始化 RandomizedSet 对象
bool insert(int val) 当元素 val 不存在时，向集合中插入该项，并返回 true ；否则，返回 false 。
bool remove(int val) 当元素 val 存在时，从集合中移除该项，并返回 true ；否则，返回 false 。
int getRandom() 随机返回现有集合中的一项（测试用例保证调用此方法时集合中至少存在一个元素）。每个元素应该有 相同的概率 被返回。
你必须实现类的所有函数，并满足每个函数的 平均 时间复杂度为 O(1) 。
*/ 

class RandomizedSet {
public:

    map<int,int> map;
    vector<int> list;
    RandomizedSet() {
        
    }
    
    bool insert(int val) {
        if(map.find(val) == map.end())
        {
            list.push_back(val);
            map.insert(pair<int,int>(val,list.size()-1));
            return true;
        }
        else
        {
            return false;
        }
    }
    
    // 不要直接用list删除val元素，因为这会造成元素的位移
    // 而是把list最后一个元素放到 原本val元素的位置上，然后list删除最后一个元素，这样不会造成元素的位移
    bool remove(int val) 
    {
        if(map.find(val)!= map.end())
        {
            // 一步一步写，可读性高不易出错
            int lastNumber = list.back();
            int targetIndex = map[val];
            list[targetIndex] = lastNumber;
            map[lastNumber] = targetIndex;
            list.pop_back();
            map.erase(val);
            return true;
        }
        else
        {
            return false;
        }
    }
    
    int getRandom() 
    {
       return list[rand() % list.size()];
    }
};

int main()
{

}