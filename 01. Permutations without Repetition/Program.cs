using System;
using System.Collections.Generic;

namespace _01._Permutations_without_Repetition
{
    public class Program
    {
        private static string[] elements;
        private static string[] permutation;
        private static List<int> usedIndices = new List<int>();

        static void Main(string[] args)
        {
            ReadElements();
            InitializePermutation();
            Permute(0);
        }

        private static void Permute(int index)
        {
            if (index >= elements.Length) // n
            {
                Print();
            }
            else
            {
                for (int current = 0; current < elements.Length; current++)
                {
                    if (!usedIndices.Contains(current))
                    {
                        usedIndices.Add(current);

                        permutation[index] = elements[current];
                        Permute(index + 1);

                        usedIndices.Remove(current);
                    }
                }
            }
        }

        private static void Print()
            => Console.WriteLine(string.Join(" ", permutation));
        private static void InitializePermutation()
          => permutation = new string[elements.Length]; // n

        private static void ReadElements()
             => elements = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    }
}
