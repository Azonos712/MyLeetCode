using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._1_Easy
{
    public class Task70 : ILeetCodeTask<int>
    {
        public int Invoke() => ClimbStairs(5);

        /// <summary>
        /// Time: O(n) / Memory: O(n)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int ClimbStairs(int n)
        {
            int[] nums = new int[n];
            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                    nums[i] = 1;
                else if (i == 1)
                    nums[i] = 2;
                else
                    nums[i] = nums[i - 1] + nums[i - 2];
            }
            return nums[n - 1];
        }
    }
}
