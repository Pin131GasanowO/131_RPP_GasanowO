using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8._3
{
    class Program
    {
        static void Main(string[] args)
        {
            GraphObject[] array = new GraphObject[20];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                int obj = rnd.Next(0, 3);
                int color = rnd.Next(0, 3);
                switch (obj)
                {
                    case 0: array[i] = new Point(); break;
                    case 1: array[i] = new Rectangle(rnd.Next(2, 8), rnd.Next(2, 8)); break;
                    case 2: array[i] = new Square(rnd.Next(2, 8)); break;
                }
                switch (color)
                {
                    case 0: array[i].Color = ConsoleColor.Red; break;

                    case 1: array[i].Color = ConsoleColor.Green; break;

                    case 2: array[i].Color = ConsoleColor.Blue; break;
                }
            }
            foreach (GraphObject g in array)
            {
                g.DrawInConsole();
            }
            Console.ReadKey();

        }
    }
    abstract class GraphObject
    {
        public ConsoleColor Color { get; set; }
        public abstract void DrawInConsole();
    }
    class Point : GraphObject
    {
        public override void DrawInConsole()
        {
            Console.ForegroundColor = this.Color;
            Console.WriteLine("*");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }
    }
    class Rectangle : GraphObject
    {
        public int width { get; set; }
        public int height { get; set; }
        public Rectangle(int h, int w)
        {
            this.width = w;
            this.height = h;
        }

        public override void DrawInConsole()
        {
            Console.ForegroundColor = this.Color;
            for (int i = 0; i < this.height; i++)
            {
                for (int j = 0; j < this.width; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }
    }
    class Square : GraphObject
    {
        public int width { get; set; }
        public Square(int w)
        {
            this.width = w;
        }

        public override void DrawInConsole()
        {
            Console.ForegroundColor = this.Color;
            for (int i = 0; i < this.width; i++)
            {
                for (int j = 0; j < this.width; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }
    }
}
