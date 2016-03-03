using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._10_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Х");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите d");
            int d = Convert.ToInt32(Console.ReadLine());
            double[] array = new double[100];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = x + (d * i);

                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
        }
    }
}

