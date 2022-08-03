using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._2_Medium
{
    public class Task74 : ILeetCodeTask<bool>
    {
        int[][] _matrix = new int[][] { new int[] { 1, 3, 5, 7 }, new int[] { 10, 11, 16, 20 }, new int[] { 23, 30, 34, 60 } };
        //int[][] _matrix = new int[][] { new int[] { 1 } };
        public bool Invoke() => SearchMatrix(_matrix, 34);

        public bool SearchMatrix(int[][] matrix, int target)
        {
            int width = matrix[0].Length;
            int height = matrix.Length;

            int l = 0;
            int r = height - 1;

            while (l <= r)
            {
                int index = (l + r) / 2;

                if (target > matrix[index][^1])
                    l = index + 1;
                else if (target < matrix[index][0])
                    r = index - 1;
                else
                    break;
            }

            if (!(l <= r))
                return false;

            int row = (l + r) / 2;
            l = 0;
            r = width - 1;
            while (l <= r)
            {
                int index = (l + r) / 2;

                if (target == matrix[row][index])
                    return true;

                if (target < matrix[row][index])
                    r = index - 1;
                else
                    l = index + 1;
            }

            return false;
        }
    }
}
