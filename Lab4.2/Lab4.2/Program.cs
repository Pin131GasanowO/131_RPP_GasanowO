using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите m: ");
            int m = Convert.ToInt32(Console.ReadLine());

            int[,] a = new int[n, m];

            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = random.Next(100);
                    Console.Write("{0,4}", a[i, j]);
                }
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                for (int j = 0; j < m; j++)
                {
                    sum += a[i, j];
                }
                Console.WriteLine("Сумма чисел в {0} столбце: {1}", i, sum);
            }
            Console.ReadKey();
        }
    }
}
