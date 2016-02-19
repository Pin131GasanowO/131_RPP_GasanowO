using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_Угадайка_с_оппонентом
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int x = int.Parse(Console.ReadLine());
            Console.Clear();

            while (true)
            {

                Console.WriteLine("Введите число");

                int y = int.Parse(Console.ReadLine());

                if (y > x + 50)
                {
                    Console.WriteLine("Ваше число намного больше");

                }
                else if (y < x - 50)
                {
                    Console.WriteLine("Ваше число намного меньше");
                }
                else if (y > x)
                {
                    Console.WriteLine("Ваше число больше");
                }

                else if (y < x)
                {
                    Console.WriteLine("Ваше число меньше");
                }
                else
                {
                    Console.WriteLine("!!!АЙ МАЛАДЦА!!!");

                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
