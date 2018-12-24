using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    public class AmazonDemoQues1
    {
        int[] states = { 1, 1, 1, 0, 1, 1, 1, 1 };
        int days = 2;
        public int[] AmazonQ1()
        {
            int n = states.Length;
            int[] temp = new int[states.Length];
            for (int i = 0; i < n; i++)
                temp[i] = states[i];

            for (int d = 0; d < days; d++)
            {
                temp[0] = 0;
                temp[n - 1] = 0;

                for (int i = 1; i < n - 1; i++)
                {
                    if ((states[i - 1] == 0 && states[i + 1] == 0) || (states[i - 1] == 1 && states[i + 1] == 1))
                        temp[i] = 0;
                    else
                        temp[i] = 1;
                }

                for (int i = 0; i < n; i++)
                    states[i] = temp[i];
            }

            return states;
        }

        int[] arr = { 2, 4 };

        public int AmazonQ2()
        {
            int n = arr.Length;

            int result = arr[0];
            for (int i = 1; i < n; i++)
                result = gcd(arr[i], result);

            return result;

        }

        int gcd(int a, int b)
        {
            if (a == 0)
                return b;
            return gcd(b % a, a);
        }


        int numDestinations = 3;
        int[,] allLocations = { { 1, 2 }, { 3, 4 }, { 1, -1 } };
        int numDeliveries = 2;

        public List<List<int>> RAmazonQ1()
        {
            var ans = new List<List<int>>();
            var d = new Dictionary<int, double>();
            int s, s1, sum;
            for (int i = 0; i < numDestinations; i++)
            {
                s = allLocations[i, 0];
                s1 = allLocations[i, 1];
                sum = (s * s) + (s1 * s1);
                d[i] = Math.Sqrt(sum);
            }

            var sortedList = d.ToList();
            sortedList.Sort((pair1, pair2) => pair1.Value.CompareTo(pair2.Value));
            int count = 0;
            List<int> a;
            foreach (var item in sortedList)
            {
                if (count < numDeliveries)
                {
                    a = new List<int>();
                    a.Add(allLocations[item.Key, 0]);
                    a.Add(allLocations[item.Key, 1]);
                    ans.Add(a);
                    count++;
                }
                else
                    break;
            }
            return ans;
        }


        int numRows = 3;
        int numColumns = 3;
         int[,] lot = { { 1, 0, 1 }, { 1, 0, 1 }, { 1, 9, 1 } };
        public int RAmazonQ2()
        {
            int ans = 0;
            ans = solveObstacle(lot, 0, 0, numRows, numColumns, ans);
            return ans;
        }

        private int solveObstacle(int[,] lot, int x, int y,int numRows, int numColumns, int ans)
        {
            if (canMove(lot, x, y, numRows, numColumns))
            { 
                if (ObstacleFound(lot, x, y))
                    return ans;
                ans++;

               solveObstacle(lot, x + 1, y, numRows, numColumns, ans);

                return solveObstacle(lot, x , y+1, numRows, numColumns, ans);
            }

            return ans;
        }
        private bool ObstacleFound(int[,] lot, int x, int y)
        {
            bool found = false;
            if (lot[x, y] == 9)
                found = true;

            return found;
        }
        private bool canMove(int[,] lot, int x, int y, int numRows, int numColumns)
        {
            // if (x,y outside maze) return false 
            return (x >= 0 && x < numRows && y >= 0 &&
                    y < numColumns && lot[x,y] == 1);
        }
    }
}
