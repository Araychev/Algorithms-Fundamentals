using System;
using System.Numerics;

namespace _01._Two_Minutes_to_Midnight_Exam_Prep
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            BigInteger binomalCoeficient = GetFactorial(n) / (GetFactorial(k) * GetFactorial(n - k));

            Console.WriteLine(binomalCoeficient);
        }

        private static BigInteger GetFactorial(int i)
        {
            BigInteger factorial = 1;
            for (int j = 2; j <= i; j++)
            {
                factorial *= j;
            }
            return factorial;
        }
    }
}
