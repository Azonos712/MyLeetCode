using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._2_Medium
{
    public class Task62 : ILeetCodeTask<int>
    {
        public int Invoke() => UniquePaths(3, 2);

        /// <summary>
        /// Time: O(m*n) / Memory: O(n)
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public int UniquePaths(int m, int n)
        {
            int[][] grid = new int[m][];
            for (int i = 0; i < m; i++)
                grid[i] = new int[n];

            grid[0][0] = 1;
            for (int k = 0; k < m; k++)
            {
                for (int l = 0; l < n; l++)
                {
                    if (k - 1 >= 0)
                        grid[k][l] += grid[k - 1][l];
                    if (l - 1 >= 0)
                        grid[k][l] += grid[k][l - 1];
                }
            }

            return grid[m - 1][n - 1];
        }

        /// <summary>
        /// Recursion Is Too Slow
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        private int GetPath(int i, int j, int m, int n)
        {
            if (i == m - 1 && j == n - 1)
                return 1;

            int number = 0;

            if (i + 1 < m)
                number += GetPath(i + 1, j, m, n);

            if (j + 1 < n)
                number += GetPath(i, j + 1, m, n);

            return number;
        }
    }
}
