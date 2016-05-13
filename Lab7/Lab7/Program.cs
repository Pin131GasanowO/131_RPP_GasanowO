using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple a1 = new Apple("Это яблоко", "дерево");
            Console.WriteLine(a1.WRTLN());
            Berry b1 = new Berry("bb1", "bb2");
            Console.WriteLine(b1.WRTLN());
            Console.ReadKey();
        }
        //static void Main(string[] args)
        //{
            //GraphObject a = new Point();
            //a.DrawSth();
            //Point b = new Point();
            //b.DrawSth();
        //}
    }
}
