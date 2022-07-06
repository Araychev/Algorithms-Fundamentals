using System;
using System.Linq;

namespace _03._Sum_with_Unlimited_Coins
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

            int count = GetCount(coins, sum);

            Console.WriteLine(count);
        }

        private static int GetCount(int[] coins, int sum)
        {
            var sums = new int[sum + 1];
            sums[0] = 1;

            for (int i = 0; i < coins.Length; i++)
            {
                for (int j = coins[i]; j < sums.Length; j++)
                {
                    sums[j] += sums[j - coins[i]];
                }
            }

            return sums[sums.Length - 1];
        }
    }
}
