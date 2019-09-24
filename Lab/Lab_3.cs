//Лаба 3 (1 завдання)
//вивести логічне значення True,
//якщо приведений вислів для запропонованих початкових даних є
//істинним, і значення False у супротивному випадку.
//Перевірити істинність вислову: &quot;Квадратне рівняння A·x 2 + B·x + C
//= 0 із даними коефіцієнтами A, B, C має дійсні корені
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            float a;
            float b;
            float c;
            double d;


            Console.WriteLine("Enter A:");
            a = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter B:");
            b = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter C:");
            c = Convert.ToSingle(Console.ReadLine());

            d = Math.Pow(b, 2) - 4 * a * c;

            if (d < 0)
            {
                Console.WriteLine("False");
            }
            if (d >= 0)
            {
                Console.WriteLine("True");
            }

            Console.ReadKey();
        }
    }
}
