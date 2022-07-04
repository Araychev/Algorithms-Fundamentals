using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Reverse_Array
{
    public class Program
    {
        private static Stack<int> reversedArr = new Stack<int>();

        public static void Main()
        {
            var arr = ReadArray();
            Reverse(arr, 0);
        }

        private static void Reverse(int[] arr, int index)
        {
            if (index == arr.Length)
            {
                Console.WriteLine(string.Join(" ", reversedArr));
            }
            else
            {
                reversedArr.Push(arr[index]);

                Reverse(arr, index + 1);
            }
        }

        private static int[] ReadArray()
            => Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
    }
}
