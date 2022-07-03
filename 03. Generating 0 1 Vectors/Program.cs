﻿using System;
using System.Collections.Generic;

namespace _03._Generating_0_1_Vectors
{
    public class Program
    {
        static void Main(string[] args)
         {
            int n = int.Parse(Console.ReadLine());

            List<string> result = new List<string>();

            GenerateVectors(result, "", n);

            Console.WriteLine(string.Join(Environment.NewLine, result));
        }

        private static void GenerateVectors(List<string> result, string temp, int n)
        {
            if (n == 0)
            {
                result.Add(temp);

                return;
            }

            for (int i = 0; i <= 1; i++)
            {
                temp = temp + i.ToString();

                GenerateVectors(result, temp, n - 1);

                temp = temp.Remove(temp.Length - 1);
            }
        }
    }
}
