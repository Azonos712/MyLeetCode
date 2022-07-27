using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._1_Easy
{
    public class Task1046 : ILeetCodeTask<int>
    {
        public int Invoke() => LastStoneWeight(new int[] { 2, 7, 4, 1, 8, 1 });

        public int LastStoneWeight(int[] stones)
        {
            PriorityQueue<int, int> q = new PriorityQueue<int, int>();
            for (int i = 0; i < stones.Length; i++)
                q.Enqueue(stones[i], -stones[i]);

            while (q.Count > 0)
            {
                if (!q.TryDequeue(out int y, out _))
                    break;

                if (!q.TryDequeue(out int x, out _))
                    return y;

                if (x != y)
                    q.Enqueue(y - x, -(y - x));

            }

            return 0;
        }
    }
}
