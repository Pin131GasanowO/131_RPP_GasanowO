using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        class Ellipse
        {
            public double VerticalRad;
            public double HorisontalRad;
            public double GetSquare()
            {
                return 3.14 * VerticalRad * HorisontalRad;
            }
            public double GetPerimetr()
            {
                return 2 * 3.14 * Math.Sqrt(0.5 * (VerticalRad * VerticalRad + HorisontalRad * HorisontalRad));
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество фигур: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            Ellipse[] ellipse = new Ellipse[n];
            for (int i = 0; i < ellipse.Length; i++)
            {
                ellipse[i] = new Ellipse();
                ellipse[i].VerticalRad = rand.Next(1, 100);
                ellipse[i].HorisontalRad = rand.Next(1, 100);
            }

            int minP = 0;
            int minS = 0;
            for (int i = 1; i < ellipse.Length; i++)
            {
                if (ellipse[minS].GetSquare() < ellipse[i].GetSquare()) minS = i;
                if (ellipse[minP].GetPerimetr() < ellipse[i].GetPerimetr()) minP = i;
            }

            Console.WriteLine("Минимальный периметр у эллипса №{0} с параметрами: а = {1}, b = {2}", minP + 1, ellipse[minP].HorisontalRad, ellipse[minP].VerticalRad);
            Console.WriteLine("Минимальная площадь у эллипса №{0} с параметрами: а = {1}, b = {2}", minS + 1, ellipse[minS].HorisontalRad, ellipse[minS].VerticalRad);
            Console.ReadKey();
        }
    }
}
