using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество фигур: ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            int[,] ellipse = new int[n, 2];

            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                ellipse[i, 0] = r.Next(1, 20);
                ellipse[i, 1] = r.Next(1, 20);
            }

            double[] S = new double[n];
            double[] P = new double[n];
            for (int i = 0; i < n; i++)
            {
                S[i] = 3.14 * ellipse[i, 0] * ellipse[i, 1];
                P[i] = 2 * 3.14 * Math.Sqrt(0.5 * (ellipse[i, 0] ^ 2 + ellipse[i, 1] ^ 2));
            }
            int minP = 0;
            int minS = 0;
            for (int i = 1; i < S.Length; i++)
            {
                if (S[i] < S[minS]) minS = i;
                if (P[i] < P[minP]) minP = i;
            } 
            
            Console.WriteLine("Минимальный периметр у эллипса №{0} с параметрами: а = {1}, b = {2}",minP + 1, ellipse[minP,0], ellipse[minP,1]);
            Console.WriteLine("Минимальная площадь у эллипса №{0} с параметрами: а = {1}, b = {2}", minS + 1, ellipse[minS, 0], ellipse[minS, 1]);
            Console.ReadKey();
        }
    }
}
