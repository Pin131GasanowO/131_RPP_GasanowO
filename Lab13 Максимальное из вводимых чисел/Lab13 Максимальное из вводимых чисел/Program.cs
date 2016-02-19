using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_Максимальное_из_вводимых_чисел
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();
            string[] strs = str.Split(' ');
            int max = int.Parse(strs[0]);
            for (int i = 1; i < strs.Length; i++)
            {
                int cur = int.Parse(strs[i]);
                if (max < cur) max = cur;
            }
            Console.WriteLine("Максимум: {0}", max);
            Console.ReadKey();
        }
    }
} 
