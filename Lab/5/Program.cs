using System;
using Logic;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the latitude of coordinate 1:");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Input the longitude of coordinate 1:");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Input the latitude of coordinate 2:");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Input the longitude of coordinate 2:");
            double y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("The distance between those points is: "+Distance.distanceBetween(x1,x2,y1,y2)+" km");
            Console.ReadKey();
        }
    }
}
