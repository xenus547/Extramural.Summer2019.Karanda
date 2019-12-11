using System;
using Logic;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(n.primeNum());
            Console.ReadKey();
        }
    }
}
