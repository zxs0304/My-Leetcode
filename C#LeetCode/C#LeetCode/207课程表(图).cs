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
        // 键是当前课，值是当前课的先行课
        //Dictionary<int, int> allCourse = new();
        //int[] visited;
        //public bool CanFinish(int numCourses, int[][] prerequisites)
        //{
        //    visited = new int[numCourses];
        //    for (int i = 0;i<prerequisites.Length;i++)
        //    {
        //        allCourse.Add(prerequisites[i][0], prerequisites[i][1]);
        //    }

        //}

        //public bool CanLearn(int course)
        //{
        //    visited[course] = 2;

        //    if (visited[course] == 1)
        //    {
        //        return true;
        //    }
        //    if (visited[course] == -1)
        //    {
        //        return false;
        //    }

        //    if (!allCourse.ContainsKey(course))
        //    {
        //        visited[course] = 1;
        //        return true;
        //    }
        //    else if (visited[course] == 0 && CanLearn(allCourse[course]) )
        //    {
        //        visited[course] = 1;
        //        return true;
        //    }

        //    visited[course] = -1;
        //    return false;
        //}

    }
}

