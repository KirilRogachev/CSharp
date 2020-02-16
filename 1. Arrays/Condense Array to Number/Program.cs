﻿using System;
using System.Linq;

namespace Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            while (numbers.Length>1)

            {
                int[] condensed = new int[numbers.Length - 1];
                numbers = condensed;
                
                for (int i = 0; i < numbers.Length-1; i++)
                {
                    condensed[i] = numbers[i] + numbers[i + 1];
                }
                
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}