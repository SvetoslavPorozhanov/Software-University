﻿using System;
using System.Linq;

namespace P08CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            while (arr.Length > 1)
            {
                int[] condensed = new int[arr.Length - 1];
                for (int i = 0; i < condensed.Length; i++)
                {
                    condensed[i] = arr[i] + arr[i + 1];

                }
                
                arr = condensed;
                
                
            }

            foreach (int num in arr)
            {
                Console.WriteLine($"{num}");
            }
            
        }
    }
}
