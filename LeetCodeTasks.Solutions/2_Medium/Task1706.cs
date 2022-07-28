using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._2_Medium
{
    public class Task1706 : ILeetCodeTask<int[]>
    {
        int[][] _grid = new int[][] {
            new int[] {1,  1,  1, 1, 1, 1 },
            new int[] {-1, -1, -1, -1, -1,-1 },
            new int[] { 1, 1, 1, 1, 1, 1 },
            new int[] { -1, -1, -1, -1, -1,-1 } };

        public int[] Invoke() => FindBall(_grid);

        public int[] FindBall(int[][] grid)
        {
            int[] result = new int[grid[0].Length];
            for (int i = 0; i < grid[0].Length; i++)
                result[i] = FindExit(grid, i);

            return result;
        }

        int FindExit(int[][] grid, int startIndex)
        {
            int i = 0, j = startIndex;
            while (i < grid.Length)
            {
                if (grid[i][j] == 1)
                {
                    if (j + 1 < grid[0].Length && grid[i][j + 1] == 1)
                    {
                        i++;
                        j++;
                    }
                    else
                    {
                        return -1;
                    }
                }
                else if (grid[i][j] == -1)
                {
                    if (j - 1 >= 0 && grid[i][j - 1] == -1)
                    {
                        i++;
                        j--;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
            return j;
        }
    }
}
