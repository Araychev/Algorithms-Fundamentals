﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Sum_with_Limited_Coins
{
    public class Program
    {
        static void Main(string[] args)
        {
            var coins = Console.ReadLine()
               .Split(" ")
               .Select(int.Parse)
               .ToArray();

            var sum = int.Parse(Console.ReadLine());

            var count = GetCount(coins, sum);

            Console.WriteLine(count);
        }

        private static int GetCount(int[] coins, int sum)
        {
            int count = 0;

            HashSet<int> sums = new HashSet<int>();
            sums.Add(0);

            foreach (var coin in coins)
            {
                var temp = new HashSet<int>(sums);

                foreach (var current in temp)
                {
                    sums.Add(current + coin);
                    if (current + coin == sum)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
