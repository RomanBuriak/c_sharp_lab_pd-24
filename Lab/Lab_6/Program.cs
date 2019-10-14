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

            int sum_prost = 0;
            int rizn_parn = 0;
            int sum_parn = 0;
            int arithmetic_mean;

            int all_sum = 0;


            List<int> elements = new List<int>();


            string str;


            Console.WriteLine("Enter list (Numeric values can be separated by a space.)");
            Console.WriteLine("For example: 123 1113 208 75");
            str = Console.ReadLine();
            string[] str_arr = str.Split(' ');


            int[] arr = new int[str.Length];

            for (int i = 0; i < str_arr.Length; i++)
            {

                try
                {
                    arr[i] = Convert.ToInt32(str_arr[i]);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadKey();
                    return;
                }
            }

            for (int i = 0; i < str_arr.Length; i++)
            {

                elements.Add(arr[i]);

                if (((arr[i] % 2) != 0 && (arr[i] % 3) != 0 && arr[i] != 1) || arr[i] == 2 || arr[i] == 3)
                {
                    sum_prost += arr[i];
                }

                if ((arr[i] % 2) == 0)
                {
                    sum_parn += arr[i];
                }

                all_sum += arr[i];

            }
            arithmetic_mean = all_sum / str_arr.Length;
            rizn_parn = sum_prost - sum_parn;


            Console.WriteLine("Your list:");
            foreach (int i in elements)
            {
                Console.Write(i);
                Console.Write(" ");

            }
            Console.WriteLine();




            Console.WriteLine("Sum simple elements = {0}", sum_prost);

            Console.WriteLine("Sum paired elements = {0}", sum_parn);

            Console.WriteLine("Sum simple elements - Sum paired elements = {0}", rizn_parn);

            Console.WriteLine("Arithmetic mean = {0}", arithmetic_mean);



            Console.ReadKey();
        }
    }
}