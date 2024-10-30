using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _836矩形重叠
    {
        //矩形以列表 [x1, y1, x2, y2] 的形式表示，
        //其中 (x1, y1) 为左下角的坐标，(x2, y2) 是右上角的坐标。矩形的上下边平行于 x 轴，左右边平行于 y 轴。
        public bool IsRectangleOverlap(int[] rec1, int[] rec2)
        {
            float a_Xmin = rec1[0];
            float a_Xmax = rec1[2];
            float a_Ymin = rec1[1];
            float a_Ymax = rec1[3];

            float b_Xmin = rec2[0];
            float b_Xmax = rec2[2];
            float b_Ymin = rec2[1];
            float b_Ymax = rec2[3];
            // 矩形A在B左边          A在B右边             A在B上面          A在B下面
            if (a_Xmax <= b_Xmin || a_Xmin >= b_Xmax || a_Ymax <= b_Ymin || a_Ymin >= b_Ymax)
            {
                return false;
            }
            else
            {
                return true;
            }


        }

    }
}
