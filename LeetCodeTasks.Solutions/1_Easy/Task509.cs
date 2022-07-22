using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._1_Easy
{
    public class Task509 : ILeetCodeTask<int>
    {
        public int Invoke() => FibByIteration(6);

        /// <summary>
        /// Time: O(2^n) / Memory: O(1)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int FibByRecursion(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;

            return FibByRecursion(n - 1) + FibByRecursion(n - 2);
        }

        /// <summary>
        /// Time: O(n) / Memory: O(n)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int FibByIteration(int n)
        {
            int length = n + 1;
            int[] fibs = new int[length];
            for (int i = 0; i < length; i++)
            {
                if (i == 0)
                    fibs[i] = 0;
                else if (i == 1)
                    fibs[i] = 1;
                else
                    fibs[i] = fibs[i - 1] + fibs[i - 2];
            }
            return fibs[length - 1];
        }
    }
}
