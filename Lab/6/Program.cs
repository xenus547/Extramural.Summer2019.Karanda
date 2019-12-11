using System;
using Logic;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string:");
            string str = Console.ReadLine();
            Console.WriteLine(str.ReverceString());
            Console.ReadKey();
        }
    }
}
