using System;
using Logic;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter hex value:");
            string hexVal = Console.ReadLine();
            int decVal = hexVal.hexToDecimial();
            Console.WriteLine("Hex value=" + hexVal + "\ndecVal=" + decVal);
            Console.ReadKey();
        }
    }
}
