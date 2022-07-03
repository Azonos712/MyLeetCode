using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._2_Medium
{
    public class Task376 : ILeetCodeTask<int>
    {
        //int[] inputs = new int[] { 1, 17, 5, 10, 13, 15, 10, 5, 16, 8 };
        int[] inputs = new int[] { 0, 0 };
        //int[] inputs = new int[] { 3, 3, 3, 2, 5 };

        public int Invoke()
        {
            return WiggleMaxLength(inputs);
        }

        /// <summary>
        /// Time: O(n) / Memory: O(1)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int WiggleMaxLength(int[] nums)
        {
            int length = nums.Length;
            int prevDiff = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                var currNum = nums[i];
                var prevNum = nums[i - 1];

                var currDiff = currNum == prevNum ? 0 : currNum > prevNum ? 1 : -1;

                if (prevDiff == -1 && currDiff == 1 || prevDiff == 1 && currDiff == -1 || prevDiff == 0 && currDiff != 0)
                    prevDiff = currDiff;
                else
                    length--;
            }

            return length;
        }
    }
}
