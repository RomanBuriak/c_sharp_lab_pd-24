//Лаба 1 (1 завдання)     
//Обчислити період коливаня маятника заданої довжини
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double length; // довжина

            double pi = Math.PI;     // число "пі"
            double g = 9.8;    // прискорення вільного падіння
            double T;      // період коливань


            do
            {
                Console.WriteLine("Задайте довжину маятника:");
                length = Convert.ToDouble(Console.ReadLine());
            } while (length < 0);

            T = 2 * pi * Math.Sqrt(length / g);

            Console.WriteLine("T = {0}", T);

            Console.ReadKey();
        }
    }
}
