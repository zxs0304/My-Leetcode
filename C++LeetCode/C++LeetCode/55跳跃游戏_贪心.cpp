#include<iostream>
 #include<vector> 
 #include<string>
 #include<map>
 #include<algorithm> 
 using namespace std; 
 /*
  55跳跃游戏 是 贪心，记录一个maxDistance即可，然后遍历数组的时候，对于每个i判断 i<=maxDistance才是可以到达的点
*/ 
//  55跳跃游戏，记录一个maxDistance即可，由于问的是是否可以到达，且nums[i]表示的是必须跳nums[i]个距离，与45.跳跃游戏II不一样，不能跳到中间的位置
// 所以不需要考虑跳跃的过程，因此直接遍历一遍全部，根据条件来不断更新maxDistance，最后比较maxDistance
    bool canJump(vector<int>& nums) {
        int n = nums.size();
        int maxDistance = nums[0];
        for(int i = 1 ; i< n;i++)
        {
            if(i<=maxDistance && nums[i] + i > maxDistance)
            {
                maxDistance = nums[i] + i;
            }
        }
        return maxDistance >= n-1;
    }

    // 45.跳跃游戏II，
    // 在每一轮跳跃，可以从 i 处向前任意选择跳 0 ~ nums[i] 个距离 ,
    // 遍历这一次跳跃中，能跳到的所有位置（即 i ~ i+nums[i] ），在这些位置中，找到能跳的最远的位置，这个位置即为我这轮要跳到的地方
    int jump(vector<int>& nums) 
    {
        int n = nums.size();
        int count = 0;
        // 记录当前的下标
        int curIndex = 0;
        while(curIndex < n-1)
        {
            // 记录这一轮能跳到的位置中，能跳到的最远的距离
            int tempMax = 0;
            // 记录这一轮能跳到的位置中，谁能跳的最远
            int nextIndex = 0;
            for(int i = curIndex ; i<= nums[curIndex] + curIndex;i++)
            {
                // !!!!!!这一轮已经可以直接跳到结束!!!!! ，如果不加这一步判断，可能会 已经可以跳到最后了，但是不结束，而是跳到i+nums[i]更大的地方
                if(i >= n-1)
                {
                    return ++count;
                }
                else if(nums[i] + i >= tempMax)
                {
                    //记录这一轮要跳去的地方
                    nextIndex = i;
                    tempMax = nums[i] + i;
                }
            }
            //跳到新的位置，更新当前位置
            curIndex = nextIndex;
            // 更新步数
            count++;
        }
        return count;
    }
    int main()
    {
        vector<int> test;
        test.push_back(2);
        test.push_back(3);
        test.push_back(1);

        jump(test);
        cout<< "1";
        return 0;
    }