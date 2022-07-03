﻿using LeetCodeTasks.Solutions;
using LeetCodeTasks.Solutions._1_Easy;
using LeetCodeTasks.Solutions._2_Medium;
using System;

namespace LeetCodeTasks.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILeetCodeTask<int> task = new Task376();
            var result = task.Invoke();
            System.Console.WriteLine(string.Join(',', result));
        }
    }
}