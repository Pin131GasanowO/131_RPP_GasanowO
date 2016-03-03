using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._10_52
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] a = Enumerable.Repeat(0, 30).Select(x => rnd.Next(0, 30)).ToArray();
            Console.WriteLine("Весь массив: ");
            Console.WriteLine(string.Join(" ", a));
            Console.WriteLine("Уникальные элементы: ");
            Console.WriteLine(string.Join(" ", a.Distinct()));
            Console.WriteLine("Повторяющиеся: ");
            Console.WriteLine(string.Join(" ", a.Where(x => a.Count(y => x == y) > 1).Distinct()));
            Console.ReadKey(true);
        }
    }
}

