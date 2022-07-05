﻿using LeetCodeTasks.Solutions;
using LeetCodeTasks.Solutions._1_Easy;
using LeetCodeTasks.Solutions._2_Medium;
using LeetCodeTasks.Solutions._3_Hard;
using System;

namespace LeetCodeTasks.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILeetCodeTask<int> task = new Task128();
            var result = task.Invoke();
            System.Console.WriteLine(string.Join(',', result));
        }
    }
}