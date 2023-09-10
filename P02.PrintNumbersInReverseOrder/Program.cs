using System;
using System.Net.Http.Headers;

namespace P02.PrintNumbersInReverseOrder
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int arrayNum = int.Parse(Console.ReadLine());
            int[] numbers = new int[arrayNum];

            for (int i = 0; i < arrayNum; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine()); ;
            }
            for (int j = arrayNum; j > 0; j--)
            {
                Console.Write($"{numbers[j-1]} ");
            }

        }
    }
}
