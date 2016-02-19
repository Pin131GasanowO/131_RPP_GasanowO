using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14_Сумма_всех_вводимых_чисел
{
    class Program
    {
        static void Main(string[] args)
        {
            int input, sum = 0;
            while ((input = int.Parse(Console.ReadLine())) != 0) sum += input;
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
