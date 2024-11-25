// FileName：207课程表.cs
// Author：duole-15
// Date：2024/11/22
// Des：描述
using System;
namespace C_LeetCode
{
    /*你这个学期必须选修 numCourses 门课程，记为 0 到 numCourses - 1 。
在选修某些课程之前需要一些先修课程。 先修课程按数组 prerequisites 给出，其中 prerequisites[i] = [ai, bi] ，表示如果要学习课程 ai 则 必须 先学习课程  bi 。
例如，先修课程对 [0, 1] 表示：想要学习课程 0 ，你需要先完成课程 1 。
请你判断是否可能完成所有课程的学习？如果可以，返回 true ；否则，返回 false 。
输入：numCourses = 2, prerequisites = [[1,0]]
输出：true
解释：总共有 2 门课程。学习课程 1 之前，你需要完成课程 0 。这是可能的。
输入：numCourses = 2, prerequisites = [[1,0],[0,1]]
输出：false
解释：总共有 2 门课程。学习课程 1 之前，你需要先完成​课程 0 ；并且学习课程 0 之前，你还应先完成课程 1 。这是不可能的。
	 */


    public class _207课程表
	{
        // 广度优先。创建一个后置课程表 记录每个课程的后置课程。 创建一个入度数组 记录每个课程所需的先行课数。
        // 每次修一个入度为0的课程（即该课程没有先修课程），然后把该课程对应的后置课程的入度减一，直到修完所有入度为0的课程，判断是否还有未休的课程
        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
            // 创建邻接表(后置课程表)
            // 由于当学完当前课程后，需要更新所有当前课程的后置课程的入度，因此 索引是当前课程号，值是 所有以当前课程为先行课的课程。(也就是当前课程的后置课程)
            var postCourses = new List<List<int>>(numCourses);

            // 创建入度数组，入度：一个课程所需要的先行课数量。因此 索引是当前课程号，值是当前课程所需要的先行课的数量
            var indegree = new int[numCourses];

            // 初始化后置课程表
            for (int i = 0; i < numCourses; i++)
            {
                postCourses.Add(new List<int>());
            }

            // 填充后置课程表和入度数组
            foreach (var item in prerequisites)
            {
                int curCourse = item[0];
                int preCourse = item[1];
                postCourses[preCourse].Add(curCourse);
                indegree[curCourse]++;
            }
            // 初始化队列
            var queue = new Queue<int>();
            for (int i = 0; i < numCourses; i++)
            {
                if (indegree[i] == 0)
                {
                    queue.Enqueue(i);
                }
            }
            int canLearnCourse = 0;
            while (queue.Count > 0)
            {
                int curCourse = queue.Dequeue();
                canLearnCourse++;
                foreach (var postCourse in postCourses[curCourse])
                {
                    indegree[postCourse]--;
                    if (indegree[postCourse] == 0)
                    {
                        queue.Enqueue(postCourse);
                    }
                }

            }
            return canLearnCourse == numCourses;
        }

    }
}

