using System;

namespace Popova.Lab3.Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите переменную n");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 1 & n <= 99)
            {
                if (n % 10 >= 2 & n % 10 <= 4 & (n > 20 | n < 10))
                {
                    Console.WriteLine($"I'am {n} goda");
                }
                else if (n % 10 != 1)
                {
                    Console.WriteLine($"I'am {n} let");
                }
                else
                {
                    Console.WriteLine($"I'am {n} god");
                }
            }
        }
    }
  }

