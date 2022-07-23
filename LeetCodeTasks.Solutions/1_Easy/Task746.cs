using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._1_Easy
{
    public class Task746 : ILeetCodeTask<int>
    {
        int[] inputs = { 10, 15, 20 };

        public int Invoke() => MinCostClimbingStairs(inputs);

        /// <summary>
        /// Time: O(n*k) / Memory: O(n) | Not my solution
        /// </summary>
        /// <param name="cost"></param>
        /// <returns></returns>
        public int MinCostClimbingStairs(int[] cost)
        {
            int[] dp = Enumerable.Repeat(int.MaxValue, cost.Length).ToArray();
            dp[0] = cost[0];
            dp[1] = cost[1];

            for (int i = 0; i < cost.Length - 1; i++)
            {
                for (int j = i + 1; j < i + 3; j++)
                {
                    if (j < cost.Length)
                        if (dp[i] + cost[j] <= dp[j])
                            dp[j] = dp[i] + cost[j];
                }
            }

            return Math.Min(dp[dp.Length - 1], dp[dp.Length - 2]);
        }
    }
}
