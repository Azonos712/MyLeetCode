using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._1_Easy
{
    public class Task733 : ILeetCodeTask<int[][]>
    {
        int[][] _image = { new int[] { 1, 1, 1 }, new int[] { 1, 1, 0 }, new int[] { 1, 0, 1 } };
        int _sr = 1;
        int _sc = 1;
        int _color = 2;

        public int[][] Invoke() => FloodFill(_image, _sr, _sc, _color);

        public int[][] FloodFill(int[][] image, int sr, int sc, int color)
        {
            Fill(image, sr, sc, color, image[sr][sc]);
            return image;
        }

        private void Fill(int[][] image, int r, int c, int color, int baseColor)
        {
            if (color == baseColor)
                return;

            if (image[r][c] == baseColor)
                image[r][c] = color;
            else
                return;

            if (r + 1 != image.Length)
                Fill(image, r + 1, c, color, baseColor);
            if (c + 1 != image[0].Length)
                Fill(image, r, c + 1, color, baseColor);
            if (r - 1 != -1)
                Fill(image, r - 1, c, color, baseColor);
            if (c - 1 != -1)
                Fill(image, r, c - 1, color, baseColor);
        }
    }
}
