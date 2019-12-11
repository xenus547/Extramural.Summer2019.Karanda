using System;
using Logic;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b:");
            int b = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine($"First number: {a}");
            Console.WriteLine($"First number: {b}");

            NumbericManipulation.Swap(ref a, ref b);

            Console.WriteLine($"First number: {a}");
            Console.WriteLine($"First number: {b}");

            Console.ReadKey();
        }
    }
}
