using System;

namespace LeetCodeTasks.Solutions._2_Medium
{
    public class Task473 : ILeetCodeTask<bool>
    {
        int[] input = { 3, 3, 3, 3, 4 };

        public bool Invoke()
        {
            return Makesquare(input);
        }

        public bool Makesquare(int[] matchsticks)
        {
            int sum = matchsticks.Sum();
            if (sum % 4 != 0)
                return false;

            int side = sum / 4;

            matchsticks = matchsticks.OrderByDescending(x => x).ToArray();

            if (PlaceMatchstick(0, matchsticks, 0, new int[4], side))
                return true;

            return false;
        }

        public bool PlaceMatchstick(int i, int[] matchsticks, int p, int[] square, int side)
        {
            if (i == matchsticks.Length)
                return false;

            if (square[p] + matchsticks[i] > side)
                return false;

            square[p] += matchsticks[i];

            if (i == matchsticks.Length - 1
                    && square[0] == side
                    && square[1] == side
                    && square[2] == side
                    && square[3] == side)
                return true;

            for (int j = 0; j < 4; j++)
                if (PlaceMatchstick(i + 1, matchsticks, j, square, side))
                    return true;

            square[p] -= matchsticks[i];

            return false;
        }
    }
}
