using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._10_76
{
    class Program
    {
        static void RandomSwap(ref int[] array)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                Swap(ref array[i], ref array[rnd.Next(array.Length - 1)]);
            }

        }

        static void Swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }

        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }
            RandomSwap(ref array);
            foreach (int a in array)
            {
                Console.WriteLine(a);
            }
            Console.ReadKey();
        }
    }
}


