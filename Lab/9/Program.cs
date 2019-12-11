using System;
using Logic;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string:");
            string str = Console.ReadLine();
            str=str.firstLatterBig();
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
