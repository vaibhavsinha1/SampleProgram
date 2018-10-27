using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    /// <summary>
    /// https://leetcode.com/explore/interview/card/top-interview-questions-hard/116/array-and-strings/830/
    /// Given n non-negative integers a1, a2, ..., an , where each represents a point at coordinate (i, ai). n vertical lines are drawn such that the two endpoints of line i is at (i, ai) and (i, 0). Find two lines, which together with x-axis forms a container, such that the container contains the most water.
    ///Note: You may not slant the container and n is at least 2.
    /// </summary>
    public class ContainerWithMostWater
    {
       int[] a = {1,8,6,2,5,4,8,3,7};
        public int FindArea()
        {
            int l = 0;
            int b = 0;
            int area =0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i+1; j < a.Length; j++)
                {
                    b = j - i;
                    l = Math.Min(a[i], a[j]);
                    area = Math.Max(area, l * b);
                }
            }

            return area;
        }
        
    }
}
