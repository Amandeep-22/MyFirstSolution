using System;

namespace MYFirstConsoleAPP
{
    internal class Loops
    {
        static void Main()
        {
            int num;
            num= Int32.Parse(Console.ReadLine());
            switch(num)
            {
                case 1:Console.WriteLine("Monday");
                    break;
                    case 2:Console.WriteLine("Tuesday");
                    break;
                case 3:Console.WriteLine("Wednesday");
                    break ;
                    case 4:Console.WriteLine("Thursday");
                    break;
                case 5:Console.WriteLine("Friday");
                    break;
                    case 6:
                    case 7:Console.WriteLine("Weekend");
                    break;
                defaut:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}
