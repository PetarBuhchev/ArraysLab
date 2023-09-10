using System;
using System.Linq;

namespace P08.CondenseArrayToNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] condensed = new int[input.Length - 1];
            int forNum = input.Length;
            if (input.Length == 1 ) { Console.WriteLine(input[0]);}
            else
            {
                for (int i = 0; i < forNum - 1; i++)
                {
                    for (int j = 0; j < input.Length - 1; j++)
                    {
                        condensed[j] = input[j] + input[j + 1];
                    }
                    if (condensed.Length == 1)
                    {
                        break;
                    }
                    input = new int[condensed.Length];
                    Array.Copy(condensed, input, condensed.Length);
                    condensed = new int[condensed.Length - 1];
                }
                Console.WriteLine(condensed[0]);
            }
        }
    }
}
