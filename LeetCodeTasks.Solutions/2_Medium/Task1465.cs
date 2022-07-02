using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._2_Medium
{
    public class Task1465 : ILeetCodeTask<int>
    {
        public int Invoke()
        {
            return MaxArea(1000000000, 1000000000, new int[] { 2 }, new int[] { 2 });
        }

        public int MaxArea(int h, int w, int[] horizontalCuts, int[] verticalCuts)
        {
            long horizontal = GetMaxLength(h, horizontalCuts);
            long vertical = GetMaxLength(w, verticalCuts);
            long result = vertical * horizontal;
            long module = Convert.ToInt64(Math.Pow(10, 9) + 7);
            return Convert.ToInt32(result % (module));
        }

        private long GetMaxLength(int l, int[] cuts)
        {
            Array.Sort(cuts); //O(nlog(n))
            long maxLength = cuts[0];

            for (int i = 1; i < cuts.Length; i++)//O(n)
            {
                var diff = cuts[i] - cuts[i - 1];
                if (diff > maxLength)
                    maxLength = diff;
            }

            long lastDiff = l - cuts[cuts.Length - 1];
            if (lastDiff > maxLength)
                maxLength = lastDiff;

            return maxLength;
        }
    }
}
