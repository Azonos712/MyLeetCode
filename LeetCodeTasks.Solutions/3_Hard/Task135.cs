using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._3_Hard
{
    public class Task135 : ILeetCodeTask<int>
    {
        //int[] inputs = new int[] { 1, 2, 2 };//4
        //int[] inputs = new int[] { 1, 0, 2 }; //5
        //int[] inputs = new int[] { 1, 2, 2, 0 };//7
        int[] inputs = new int[] { 2, 2, 2 };//3

        public int Invoke()
        {
            return Candy(inputs);
        }

        /// <summary>
        /// Time: O(3n) / Memory: O(3n) | Not my solution
        /// </summary>
        /// <param name="ratings"></param>
        /// <returns></returns>
        public int Candy(int[] ratings)
        {
            var l2r = Enumerable.Repeat(1, ratings.Length).ToArray();
            var r2l = Enumerable.Repeat(1, ratings.Length).ToArray();
            var candies = new int[ratings.Length];

            for (int i = 1; i < ratings.Length; i++)
                if (ratings[i] > ratings[i - 1])
                    l2r[i] = l2r[i - 1] + 1;

            for (int i = ratings.Length - 2; i >= 0; i--)
                if (ratings[i] > ratings[i + 1])
                    r2l[i] = r2l[i + 1] + 1;

            for (int i = 0; i < ratings.Length; i++)
                candies[i] = Math.Max(l2r[i], r2l[i]);

            return candies.Sum();
        }
    }
}
