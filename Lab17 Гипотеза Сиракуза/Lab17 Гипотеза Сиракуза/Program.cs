using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17_Гипотеза_Сиракуза
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.Write("Введите число: ");
            x = Convert.ToInt32(Console.ReadLine());
            do
            {
                if (x % 2 == 0)
                {
                    x = x / 2;
                }
                else
                {
                    x = (3 * x + 1) / 2;
                }
            }
            while (x != 1);
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
