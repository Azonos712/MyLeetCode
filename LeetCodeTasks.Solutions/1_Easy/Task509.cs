using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._1_Easy
{
    public class Task509 : ILeetCodeTask<int>
    {
        public int Invoke()
        {
            return Fib(6);
        }

        /// <summary>
        /// Time: O(2^n) / Memory: O(n)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int Fib(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;

            return Fib(n - 1) + Fib(n - 2);
        }
    }
}
