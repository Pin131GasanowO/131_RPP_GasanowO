using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._10_52
{
    class Program
    {
        static bool isRepit(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int element = array[i];
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (element == array[j]) return true;
                }
            }
            return false;
        }

        static void Main(string[] args)
        {
            int[] a = new int[5];
            Random rnd = new Random();
            for (int i = 0; i < a.Length;i++ )
            {
                int abc = rnd.Next(10);
                a[i] = abc;
            }
            if (isRepit(a)) Console.WriteLine("Есть повторяющиекся элементы");

            Console.ReadKey();
        }

    }
}

