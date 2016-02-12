using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIME_IS_DEAD
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;                                        //1.
            Console.Write("Введите значение x: ");
            x = Convert.ToInt32(Console.ReadLine());      //2.
            int y; //1.
            Console.Write("Введите значение y: ");
            y = Convert.ToInt32(Console.ReadLine());      //2.
            int z = (y + x) - 1;                          //3,6.

            Condition:
            if (z >= 0)
            {
                Console.WriteLine(z--);           //7.
                goto Condition;
            }

        Start:

            Console.WriteLine(z--);
            if (z >= 0)
            {
                goto Start;                           //8.
            }

            do
            {
                Console.WriteLine(z--);               //9.
            }
            while (z >= 0);

            for (int i = z; z >= 0; i--)                  //10.
            {
                Console.WriteLine(i);
            }

            if (z > 0)
                Console.WriteLine("z положительное");     //5.
            else Console.WriteLine("z отрицательное");

            if (z % 2 == 0)
                Console.WriteLine("z четное");
            else Console.WriteLine("z не четное");        //5.

            if (z % 5 == 0)
                Console.WriteLine("z делится на 5");
            else Console.WriteLine("z не делится на 5");  //5.

            if (z % 10 == 0)
                Console.WriteLine("z делится на 10");
            else Console.WriteLine("z не делится на 10"); //5.

            if (z % 20 == 0)
                Console.WriteLine("z делится на 20");
            else Console.WriteLine("z не делится на 20"); //5.

            Console.ReadKey();
        }
    }
}

