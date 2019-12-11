using System;
using Logic;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter decimial:");
            int dec = int.Parse(Console.ReadLine());
            Console.WriteLine(dec.ToB());
            Console.ReadKey();
        }
    }
}
