using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._2_Medium
{
    public class Task1696 : ILeetCodeTask<int>
    {
        int[] nums = { 1, -5, -20, 4, -1, 3, -6, -3 };
        int k = 2;
        public int Invoke()
        {
            return MaxResult(nums, k);
        }

        /// <summary>
        /// True solution, but Time Limit Exceeded
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int MaxResult(int[] nums, int k)
        {
            int[] dp = Enumerable.Repeat(int.MinValue, nums.Length).ToArray();
            dp[0] = nums[0];

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j <= i + k && j < nums.Length; j++)
                {
                    if (dp[i] + nums[j] >= dp[j])
                        dp[j] = dp[i] + nums[j];
                }
            }
            return dp[nums.Length - 1];
        }
    }
}
