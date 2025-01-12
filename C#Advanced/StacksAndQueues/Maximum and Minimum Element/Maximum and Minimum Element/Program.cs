﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int queries = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            for (int i = 1; i <= queries; i++)
            {
                int[] command = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (command[0] == 1)
                {
                    stack.Push(command[1]);
                }
                else if (command[0] == 2 && stack.Count > 0)
                {
                    stack.Pop();
                }
                else if (command[0] == 3 && stack.Count > 0)
                {
                    Console.WriteLine(stack.Max());
                }
                else if (command[0] == 4 && stack.Count > 0)
                {
                    Console.WriteLine(stack.Min());
                }
            }

            while (stack.Count > 0)
            {
                if (stack.Count == 1)
                {
                    Console.Write(stack.Pop());
                }
                else
                {
                    Console.Write($"{stack.Pop()}, ");
                }
            }
        }
    }
}
