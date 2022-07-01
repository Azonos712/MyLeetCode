using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeTasks.Solutions._1_Easy
{
    public class Task1710 : ILeetCodeTask<int>
    {
        int[][] boxTypes = new int[][] {
            new int[] { 2, 1 },
            new int[] { 4, 4 },
            new int[] { 3, 1 },
            new int[] { 4, 1 },
            new int[] { 2, 4 },
            new int[] { 3, 4 },
            new int[] { 1, 3 },
            new int[] { 4, 3 },
            new int[] { 5, 3 },
            new int[] { 5, 3 },
        };

        int truckSize = 13;

        public int Invoke()
        {
            return MaximumUnits(boxTypes, truckSize);
        }

        public int MaximumUnits(int[][] boxTypes, int truckSize)
        {
            int maxUnits = 0;

            var sortedArray = boxTypes.OrderByDescending(x => x[1]);

            foreach (var pair in sortedArray)
            {
                for (int j = 0; j < pair[0]; j++)
                {
                    if (truckSize > 0)
                    {
                        maxUnits += pair[1];
                        truckSize--;
                    }
                }
            }

            return maxUnits;
        }
    }
}
