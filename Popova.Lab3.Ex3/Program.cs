using System;

namespace Popova.Lab3.Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите переменную n ");
            int n = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Console.WriteLine("there is 4 figure");
                    break;
                case 2:
                    Console.WriteLine("there is 2 figure");
                    break;
                case 3:
                    Console.WriteLine("there is 1 figure");
                    break;
                case 4:
                    Console.WriteLine("there is 0 figure");
                    break;
                case 5:
                    Console.WriteLine("there is 3 figure");
                    break;
                case 6:
                    Console.WriteLine("there is 1 figure");
                    break;
                case 7:
                    Console.WriteLine("there is 2 figure");
                    break;
                case 8:
                    Console.WriteLine("there is 4 figure");
                    break;
            }
        }
    }
}
