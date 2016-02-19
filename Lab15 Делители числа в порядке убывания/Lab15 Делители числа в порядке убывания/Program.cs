using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15_Делители_числа_в_порядке_убывания
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, a;
            Console.Write("Введите число ");
            x = Convert.ToInt32(Console.ReadLine());

            for (a = x; a <= x; a--)
            {
                if (a > 0)
                {
                    if ((x % a) == 0)
                        Console.WriteLine("Делитель числа {0} : {1}", x, a);
                }
            }
            Console.ReadKey();
        }
    }
}

