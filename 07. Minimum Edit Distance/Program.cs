﻿using System;

namespace _07._Minimum_Edit_Distance
{
    public class Program
    {
        private static int[,] matrix;

        static void Main(string[] args)
        {
            var replace = int.Parse(Console.ReadLine());
            var insert = int.Parse(Console.ReadLine());
            var delete = int.Parse(Console.ReadLine());

            string firstWord = Console.ReadLine();
            string secondWord = Console.ReadLine();

            

            matrix = new int[firstWord.Length + 1, secondWord.Length + 1];




            var operationsCount = GetOperationsCount(firstWord, secondWord);

            var difference = firstWord.Length - secondWord.Length;

            var result = 0;

            if (difference < 0)
            {
                difference = Math.Abs(difference);
                if (replace < insert + delete)
                {
                    result = (((operationsCount - difference) / 2) * replace) + (difference * insert);
                }
                else
                {
                    replace = insert + delete;
                    result = (((operationsCount - difference) / 2) * replace) + (difference * insert);
                }
            }
            else
            {
                if (replace < insert + delete)
                {
                    result = (((operationsCount - difference) / 2) * replace) + (difference * delete);
                }
                else
                {
                    replace = insert + delete;
                    result = (((operationsCount - difference) / 2) * replace) + (difference * delete);
                }
            }



            Console.WriteLine($"Minimum edit distance: {result}");
        }

        private static int GetOperationsCount(string firstWord, string secondWord)
        {
            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                matrix[i, 0] = i;
            }

            for (int i = 1; i < matrix.GetLength(1); i++)
            {
                matrix[0, i] = i;
            }

            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    if ((int)firstWord[i - 1] == (int)secondWord[j - 1])
                    {
                        matrix[i, j] = matrix[i - 1, j - 1];
                    }
                    else
                    {
                        matrix[i, j] = Math.Min(matrix[i - 1, j], matrix[i, j - 1]) + 1;
                        
                    }
                }
            }

          

            return matrix[firstWord.Length, secondWord.Length];
        }
    }
}
