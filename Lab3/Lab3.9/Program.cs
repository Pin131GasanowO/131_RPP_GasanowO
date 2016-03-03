using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._9
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = new double[100];
            for (int i = 1; i <= array.Length; i++)
            {
                array[i - 1] = 1 - (i * 0.01);

                Console.WriteLine(array[i - 1]);
            }
            Console.ReadKey();
        }
    }
}

