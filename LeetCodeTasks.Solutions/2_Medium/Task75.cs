using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._2_Medium
{
    public class Task75 : ILeetCodeTask<int[]>
    {
        int[] _nums = { 2, 0, 2, 1, 1, 0 };

        public int[] Invoke() => Sort(_nums);

        public int[] Sort(int[] nums)
        {
            if (nums.Length < 2)
                return nums;

            int pivot = nums[nums.Length / 2];

            int index = Array.IndexOf(nums, pivot);
            IEnumerable<int> arr = nums.Where((val, idx) => idx != index);

            IEnumerable<int> less = arr.Where(x => x <= pivot);
            IEnumerable<int> greater = arr.Where(x => x > pivot);

            return Sort(less.ToArray()).Append(pivot).Concat(Sort(greater.ToArray())).ToArray();
        }
    }
}
