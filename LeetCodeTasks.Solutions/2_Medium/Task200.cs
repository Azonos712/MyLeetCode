using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LeetCodeTasks.Solutions._2_Medium
{
    public class Task200 : ILeetCodeTask<int>
    {
        char[][] _grid =
        {
            new char[] {'1','1','0','0','0'},
            new char[] {'1','1','0','0','0'},
            new char[] {'0','0','1','0','0'},
            new char[] {'0','0','0','1','1'}
        };

        public int Invoke() => NumIslands(_grid);

        public int NumIslands(char[][] grid)
        {
            int num = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        MarkIsland(grid, i, j);
                        num++;
                    }

                }
            }
            return num;
        }

        private void MarkIsland(char[][] grid, int i, int j)
        {
            if (grid[i][j] == '0')
                return;

            if (grid[i][j] == '1')
                grid[i][j] = '0';

            if (i + 1 != grid.Length)
                MarkIsland(grid, i + 1, j);
            if (j + 1 != grid[0].Length)
                MarkIsland(grid, i, j + 1);
            if (i - 1 != -1)
                MarkIsland(grid, i - 1, j);
            if (j - 1 != -1)
                MarkIsland(grid, i, j - 1);
        }
    }
}
