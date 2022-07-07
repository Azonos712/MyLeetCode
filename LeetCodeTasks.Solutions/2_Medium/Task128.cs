using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._2_Medium
{
    public class Task128 : ILeetCodeTask<int>
    {
        //int[] inputs = new int[] { 100, 4, 200, 1, 3, 2 };
        //int[] inputs = new int[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 };
        int[] inputs = new int[] { 1, 2, 0, 1 };

        public int Invoke()
        {
            return LongestConsecutive(inputs);
        }

        /// <summary>
        /// Time: O(n) / Memory: O(n) | Not my solution | We can use Hashset instead Dictionary
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int LongestConsecutive(int[] nums)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            var maxLength = 0;

            for (int i = 0; i < nums.Length; i++)
                map.TryAdd(nums[i], nums[i] + 1);

            foreach (KeyValuePair<int, int> pair in map)
            {
                if (map.ContainsKey(pair.Key - 1))
                    continue;

                var currLength = 1;
                var next = pair.Value;

                while (map.TryGetValue(next, out next))
                    currLength++;

                if (currLength >= maxLength)
                    maxLength = currLength;
            }

            return maxLength;
        }

        /// <summary>
        /// Time Limit Exceeded
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int LongestConsecutiveSlow(int[] nums)
        {
            Array.Sort(nums);

            var maxLength = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int currLength = 1;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] - nums[j - 1] == 1)
                        currLength++;
                    else if (nums[j] == nums[j - 1])
                        continue;
                    else
                        break;

                }

                if (currLength >= maxLength)
                    maxLength = currLength;
            }

            return maxLength;
        }
    }
}
