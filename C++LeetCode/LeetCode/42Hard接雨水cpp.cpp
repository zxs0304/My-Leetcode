#include<stdio.h>
#include<vector>
using namespace std;

//求每一列的水，我们只需要关注当前列，以及左边最高的墙，右边最高的墙就够了,根据较矮的那个墙和当前列的墙的高度可以分为三种情况。
//只有较矮的墙的高度大于当前列的墙的高度，当前列才可以盛水，盛水量为较矮墙减去当前列的高度。
int trap(vector<int>& height) {
	int len = height.size();
	vector<int> left(len); //left数组表示第i列的左边的列中，墙最高的值(不包括第i列本身)
	vector<int> right(len);
	left[0] = 0;
	right[len - 1] = 0;
	int sum = 0;
	for (int i = 1; i < len - 1; i++) 
	{
		left[i] = max(left[i-1],height[i-1]);
	}
	for (int j = len-2 ; j>=0; j--)
	{
		right[j] = max(right[j+1], height[j+1]);
	}
	
	for (int k = 1; k < len - 1; k++)
	{
		int minValue = min(left[k], right[k]);
		if (minValue > height[k]) {
			sum += minValue - height[k];
		}
	}

	return sum;
}