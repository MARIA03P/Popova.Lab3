using System;

namespace Popova.Lab3.Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("вводим переменную x");
            bool x = Convert.ToBoolean(Console.ReadLine());
            bool y = Convert.ToBoolean(Console.ReadLine());
            bool z = Convert.ToBoolean(Console.ReadLine());
            bool f;

            f = x | !y | !z | !x;
            if (f)
            {
                Console.WriteLine("f=true");
            }
            else
                Console.WriteLine("f = false");
        }
    }
}
