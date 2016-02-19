using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_Угадайка_с_компьютером
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите начало интервала: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введите конец интервала: ");
            int y = int.Parse(Console.ReadLine());

            Random rand = new Random();

            int A = rand.Next(x, y);
            int l = 0;
            while (true)
            {
                Console.WriteLine("Введите число: ");

                int B = int.Parse(Console.ReadLine());

                l++;
                if (B == A)
                {
                    Console.WriteLine("Вы угадали с {0} попытки: ", l);
                    break;
                }

                else if (B > A)
                {
                    Console.WriteLine("Ваше число больше");
                }
                else
                {
                    Console.WriteLine("Ваше число меньше");
                }
            }
            Console.ReadKey();
        }
    }
}
