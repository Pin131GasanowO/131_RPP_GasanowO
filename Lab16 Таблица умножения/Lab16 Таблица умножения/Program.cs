using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16_Таблица_умножения
{
    class Program
    {
        private const int n = 9;
        static void Main(string[] args)
        {
            int i;
            int j;
            Console.Write("Pifagor's table\n");
            for (i = 1; i <= n; i++) //внешний цикл
            {
                Console.Write(" \n");
                for (j = 1; j <= n; j++) //внутрненний цикл
                {
                    Console.Write(j * i);
                    Console.Write(" ");
                }
            }
            Console.ReadKey();
        }
    }
}
