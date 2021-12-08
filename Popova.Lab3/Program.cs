using System;

namespace Popova.Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Определеяем переменные x и y как числа с двойной точностью
            double x, y = 0;
            Console.Write("Введите x: ");
            x = Convert.ToDouble(Console.ReadLine());
            if (x > 1)
            {
                y = x + 3;
            }
            else if (x >= 0 || x <= 1)
            {
                y = 2 * x;
            }
            else
            {
                y = 1 + 2 * x;
            }
            Console.WriteLine(y);
        }
    }
}
