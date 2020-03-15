using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KMV9
{

    class Program
    {
        static void Main(string[] args)
        {
            double x = 0;
            double E = 0 ;
            try
            {
                string строкаВвода = Console.ReadLine();
                string[] аргумент = строкаВвода.Replace('.', ',').Split(' ');
                x = Convert.ToDouble(аргумент[0]);
                E = Convert.ToDouble(аргумент[1]);
            }
            catch
            {
                Console.WriteLine("неверные данные");
                Main(args);
            }
            double слагаемое = 0, сумма = слагаемое;
            double uslovie = 1;
            for (int n = 0; uslovie >= E; n++)
            {

                int factorialN = 1;

                for (int i = 2; i <= n; i++)             //Факториал n
                {
                    factorialN = factorialN * i;
                }

                uslovie = Math.Abs(Math.Pow(x, n) / factorialN);
                /////////////////////////////////////
                int f = (2 * n);
                int factorialF = 1;

                for (int i = 2; i <= f; i++)
                {
                    factorialF = factorialF * i;
                }
                слагаемое = Math.Pow(-1,n) * (2 * Math.Pow(n,2) + 1) * Math.Pow(x, 2 * n) / factorialF;        //Факториал знаменателя функции
                сумма += слагаемое;
            }
            Console.Write(сумма);
            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
    }
}