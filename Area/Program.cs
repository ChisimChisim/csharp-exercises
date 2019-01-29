using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = -1;
            do
            {
                Console.WriteLine("Enter a radius: ");
                r = double.Parse(Console.ReadLine());
            } while (r < 0);
            double result = r * r * Math.PI;
            Console.WriteLine("The area of a circle with radius " + r + " is: " + result);
            Console.ReadLine();
        }
    }
}
