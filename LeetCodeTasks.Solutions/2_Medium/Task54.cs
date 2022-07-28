using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._2_Medium
{
    public class Task54 : ILeetCodeTask<IList<int>>
    {
        //int[][] _matrix = new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } };
        int[][] _matrix = new int[][] { new int[] { 1 }, new int[] { 4 } };

        public IList<int> Invoke() => SpiralOrder(_matrix);

        public IList<int> SpiralOrder(int[][] matrix)
        {
            int marked = 1000;
            Direction dir = Direction.None;
            List<int> result = new List<int>();
            int i = 0, j = 0;

            while (true)
            {
                switch (dir)
                {
                    case Direction.Top:
                        if (i - 1 == -1 || matrix[i - 1][j] == marked)
                        {
                            dir = Direction.Right;
                            j++;
                        }
                        else
                        {
                            i--;
                        }
                        break;
                    case Direction.Bottom:
                        if (i + 1 == matrix.Length || matrix[i + 1][j] == marked)
                        {
                            dir = Direction.Left;
                            j--;
                        }
                        else
                        {
                            i++;
                        }
                        break;
                    case Direction.Right:
                        if (j + 1 == matrix[0].Length || matrix[i][j + 1] == marked)
                        {
                            dir = Direction.Bottom;
                            i++;
                        }
                        else
                        {
                            j++;
                        }
                        break;
                    case Direction.Left:
                        if (j - 1 == -1 || matrix[i][j - 1] == marked)
                        {
                            dir = Direction.Top;
                            i--;
                        }
                        else
                        {
                            j--;
                        }
                        break;
                    case Direction.None:
                        dir = Direction.Right;
                        break;
                }

                if (i >= matrix.Length || j >= matrix[0].Length || i < 0 || j < 0 || matrix[i][j] == marked)
                    break;

                result.Add(matrix[i][j]);
                matrix[i][j] = marked;
            }

            return result;
        }

        enum Direction
        {
            None,
            Top,
            Bottom,
            Right,
            Left
        }
    }
}
