using System;

namespace _04._Recursive_Factorial
{
    public class Program
    {
        static void Main(string[] args)
       {
            int n = int.Parse(Console.ReadLine());

            long result = CalcFactorial(n);

            Console.WriteLine(result);
        }

        private static long CalcFactorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            return n * CalcFactorial(n - 1);
        }
    }
}
