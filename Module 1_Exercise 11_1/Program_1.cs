using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_1_Exercise_11_1
{
    class Program_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Создадим экземпляр класса для решения линейного уравнения 0 = kx + b.");
            linearEquation myLinearEquation;

            Console.WriteLine("Введите k");
            myLinearEquation.k = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите b");
            myLinearEquation.b = Convert.ToDouble(Console.ReadLine());

            double solution = myLinearEquation.Root();
            Console.WriteLine("Решение уравнения: x = {0}", solution);
            Console.ReadKey();
        }

        struct linearEquation
        {
            public double k;
            public double b;

            public double Root()
            {
                double x = -b / k;
                return x;
            }
        }
    }
}
