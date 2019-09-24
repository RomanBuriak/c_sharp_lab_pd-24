//Лаба 2 (1 завдання) 
//Обчислити задану суму числового ряду для заданих початкових індексів nn та nk. 
//Обов'язково перевірити виконання нерівностей 0<=nn<=nk
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int nk = -1;
            int nn = -1;
            double Sum = 0;

            try
            {
                Console.WriteLine("Введіть nk:");
                nk = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введіть nn:");
                nn = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            if (nn >= 0 && nk >= nn)
            {
                for (int k = nn; k <= nk; k++)
                {
                    Sum += (Math.Pow(k, 2) - 3) / (Math.Pow((-1), k) * Math.Pow(k, 2) + 5);
                }
                Console.WriteLine("Sum = {0}", Sum);
            }
            else
            {
                Console.WriteLine("Нерівність (0 <= nn <= nk) не виконується!");

            }






            Console.ReadKey();
        }
    }
}
