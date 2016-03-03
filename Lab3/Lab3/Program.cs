using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[100];
            for (int i = 1; i <= array.Length; i++)
            {
                array[i - 1] = i;
                Console.WriteLine(array[i - 1]);
            }
            Console.ReadKey();
        }
    }
}

