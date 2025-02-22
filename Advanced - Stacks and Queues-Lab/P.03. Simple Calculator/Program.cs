﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace P._03._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Stack<string> stack = new Stack<string>(input.Reverse());

            while (stack.Count != 1)
            {
                int first = int.Parse(stack.Pop());

                string @operator = stack.Pop();

                int second = int.Parse(stack.Pop());

                switch (@operator)
                {
                    case "+":

                        stack.Push((first + second).ToString());

                        break;

                    case "-":

                        stack.Push((first - second).ToString());

                        break;
                }

            }
            Console.WriteLine(stack.Pop());
        }
    }
}
