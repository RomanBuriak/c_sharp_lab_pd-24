//laba 5 (1 варіант)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int k;
            int m, n;
            int sum = 0, prod = 1;

            do
            {
                Console.WriteLine("Enter m:");
                m = Convert.ToInt32(Console.ReadLine());
            } while (m <= 0);
            do
            {
                Console.WriteLine("Enter n:");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n <= 0);

            int[,] matr = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("M[{0}][{1}]:", i, j);
                    matr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0}", matr[i, j]);
                    Console.Write("  ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Enter k:");
            k = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                sum += matr[i, k];
                prod *= matr[i, k];
            }

            Console.WriteLine("Sum = {0}", sum);
            Console.WriteLine("Product = {0}", prod);


            Console.ReadKey();
        }
    }
}
