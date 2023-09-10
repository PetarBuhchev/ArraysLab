using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace P04.ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] elements = Console.ReadLine().Split().ToArray();

            for (int i = 0; i < elements.Length / 2; i++) 
            {
                string firstElement = elements[i];
                string lastElement = elements[elements.Length - i - 1];

                elements[i] = lastElement;
                elements[elements.Length - 1 - i] = firstElement;
            }
            Console.WriteLine(string.Join(' ', elements));
        }
    }
}
