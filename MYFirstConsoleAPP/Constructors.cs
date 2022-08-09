using System;
namespace MyFirstConsoleAppNew
{
    class A
    {
        public virtual void Add(int num1, int num2)
        {
            Console.WriteLine("Sum is {0}:", (num1 + num2));
        }
    }
    class B:A 
    {
        public void Sub(int num1, int num2)
        {
            Console.WriteLine("Diff of numbers is {0}:", (num1 - num2));
        }
        public override void Add(int num1, int num2)
        {
            Console.WriteLine("Sum of numbers is {0}:", (num1 + num2));
        }
    }

    interface IRectangle
    {
        void GetArea(double length, double breadth);
          
    }

    interface ISquare
    {
        void GetArea(double side);
    }
    class Shape : IRectangle, ISquare
    {
        public void GetArea(double length, double breadth)
        {
            double area = length * breadth;
            Console.WriteLine($"Area is Rectangle {area}");
        }
        public void GetArea(double side)
        {
            double area = side*side;
            Console.WriteLine($"Area is Square {area}");
        }

    }
       
    
    internal class Program
    {
        static void Main(string[] args)
        {
           Shape obj= new Shape();
            obj.GetArea(10, 20);
            obj.GetArea(10);
         

        }

    }
}
