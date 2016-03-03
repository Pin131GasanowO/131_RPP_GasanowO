using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._10_28
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum1 = 0;
            int sum = 0;
            int[] array = new int[100];
            Random f = new Random();
            for (int i = 0; i < array.Length; i++)
            {

                array[i] = f.Next(100);

            }
            sum1 = array[0] + array[99];
            for (int i = 1; i < array.Length; i += 2)
            {
                if (array[i] > sum1)
                { sum += array[i]; }
            }

            Console.WriteLine(sum1);
            Console.ReadKey();
        }
    }
}

