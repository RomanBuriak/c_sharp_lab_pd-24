//документ лаба 4; в середині написано 5 лаба; завдання 22
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int nom = 0;
            int first = 0;

            Console.WriteLine("Enter size arrey:");
            n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter element {0}:", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
                if (arr[i] != i + 1 && n > 1)
                {

                    first++;
                    if (first == 1)
                    {
                        nom = i;
                    }
                }


            }


            if (first > 0)
            {
                Console.WriteLine("Number element {0}", nom);
            }

            if (first == 0 && n > 1)
            {
                Console.WriteLine("Output: 0");
            }

            if (n <= 1)
            {
                Console.WriteLine("N must be larger that 1");
            }


            Console.ReadKey();
        }
    }
}
