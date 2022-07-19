using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._1_Easy
{
    public class Task118 : ILeetCodeTask<IList<IList<int>>>
    {
        public IList<IList<int>> Invoke() => Generate(5);
        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> rows = new List<IList<int>>();

            for (int i = 0; i < numRows; i++)
            {
                rows.Add(new List<int>(i + 1));

                for (int j = 0; j < i + 1; j++)
                {
                    if (j == 0 || j == i)
                        rows[i].Add(1);
                    else
                        rows[i].Add(rows[i - 1][j - 1] + rows[i - 1][j]);
                }
            }

            return rows;
        }
    }
}
