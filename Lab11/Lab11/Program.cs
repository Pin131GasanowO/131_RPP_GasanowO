using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            string x;
            int i;
            Console.Write("Скажи пароль и проходи: ");
            for (i = 0; i < 3; i++)
            {
                x = (Console.ReadLine());
                if (x == "time is dead")
                {
                    Console.Write("Можешь проходить сталкер. Удачной охоты. ");
                }
                else
                {
                    Console.Write("Ты ошибся. Пробуй снова! ");
                    Console.Write("До провала осталось: ");
                    Console.Write(3 - i);
                    Console.Write(" попытки. ");
                }
            }
            Console.ReadKey();
        }
    }
}