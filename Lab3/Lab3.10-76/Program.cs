using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._10_76
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длинну массива:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] x = new int[n];
            Random z = new Random();
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = z.Next(n);
                Console.WriteLine(x[i]);

            }
            Console.ReadKey();
        }
    }
}

