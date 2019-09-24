//6 лаба (12 завдання)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int e, n;
            int sum_prost = 0;
            int rizn_parn = 0;
            int sum_parn = 0;


            Console.WriteLine("Enter the number of elements in the list:");
            n = Convert.ToInt32(Console.ReadLine());

            List<int> elements = new List<int>();



            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter element ({0}):", i);
                e = Convert.ToInt32(Console.ReadLine());
                elements.Add(e);

                if (((e % 2) != 0 && (e % 3) != 0 && e != 1) || e == 2 || e == 3)
                {
                    sum_prost += e;
                }

                if ((e % 2) == 0)
                {
                    sum_parn += e;
                }
            }
            rizn_parn = sum_prost - sum_parn;


            Console.WriteLine("Your list:");
            foreach (int i in elements)
            {
                Console.Write(i);
                Console.Write(" ");

            }
            Console.WriteLine();




            Console.WriteLine("Sum simple elements = {0}", sum_prost);

            Console.WriteLine("Sum simple elements - Sum paired elements = {0}", rizn_parn);



            Console.ReadKey();
        }
    }
}
