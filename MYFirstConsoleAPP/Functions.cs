using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstConsoleAPP
{
    internal class Functions
    {
        static void Main()
        {
            Console.WriteLine("enter length and breadth:");
            double length = double.Parse(Console.ReadLine());
            double breadth = double.Parse(Console.ReadLine());
            double peri;
            double result= Rectangle( length,breadth, out peri);
            Console.WriteLine("Area of rectangle is {0}",result);
            Console.WriteLine("Perimeter of rectangle is {0}", peri);
        }
        static double Rectangle(double length, double breadth, out double perimeter)
        {

            double area = length * breadth;
            perimeter = 2 * (length + breadth);
            return area;
        }
    }
}
