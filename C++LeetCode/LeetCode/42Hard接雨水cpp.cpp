#include<stdio.h>
#include<vector>
using namespace std;

//��ÿһ�е�ˮ������ֻ��Ҫ��ע��ǰ�У��Լ������ߵ�ǽ���ұ���ߵ�ǽ�͹���,���ݽϰ����Ǹ�ǽ�͵�ǰ�е�ǽ�ĸ߶ȿ��Է�Ϊ���������
//ֻ�нϰ���ǽ�ĸ߶ȴ��ڵ�ǰ�е�ǽ�ĸ߶ȣ���ǰ�вſ���ʢˮ��ʢˮ��Ϊ�ϰ�ǽ��ȥ��ǰ�еĸ߶ȡ�
int trap(vector<int>& height) {
	int len = height.size();
	vector<int> left(len); //left�����ʾ��i�е���ߵ����У�ǽ��ߵ�ֵ(��������i�б���)
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