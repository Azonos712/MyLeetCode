using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._1_Easy
{
    public class Task121 : ILeetCodeTask<int>
    {
        int[] _input = { 25, 50, 7, 1, 5, 3, 6, 4 };
        public int Invoke()
        {
            return MaxProfit(_input);
        }

        public int MaxProfitSlow(int[] prices)
        {
            int[] profits = new int[prices.Length];
            for (int i = 0; i < prices.Length; i++)
            {
                for (int j = i + 1; j < prices.Length; j++)
                {
                    int profit = prices[j] - prices[i];
                    if (profit > profits[i])
                        profits[i] = profit;
                }
            }

            return profits.Max();
        }

        /// <summary>
        /// Time: O(n) / Memory: O(1)
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            int left = 0;
            int right = 1;

            while (right != prices.Length)
            {
                int profit = prices[right] - prices[left];
                if (maxProfit < profit)
                    maxProfit = profit;

                if (prices[left] > prices[right])
                    left = right;

                right++;
            }

            return maxProfit;
        }
    }
}
