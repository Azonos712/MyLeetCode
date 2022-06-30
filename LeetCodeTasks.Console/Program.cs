using LeetCodeTasks.Solutions;
using LeetCodeTasks.Solutions._1_Easy;
using System;

namespace LeetCodeTasks.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILeetCodeTask<int[]> task = new Task1();
            var result = task.Invoke();
            System.Console.WriteLine(string.Join(',', result));
        }
    }
}