using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Document doc = new Document();
            Console.WriteLine("1-Создать документ вручную");
            Console.WriteLine("2-Создать случайный документ");
            int i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1: doc.GetManualDocument(); break;
                case 2: doc.GetRandomDocument(5); break;
            }
            Console.Clear();
            doc.WriteDoc();
            Console.ReadKey();
        }
        class Document
        {
            public List<IPrintable> DocData { get; set; }
            public void WriteDoc()
            {
                foreach (IPrintable data in this.DocData)
                {
                    data.PrintInConsole();
                }
            }
            string GenerateRandomText()
            {
                Random rnd = new Random();
                string s = "";
                int l = rnd.Next(50);
                for (int i = 0; i < l; i++)
                {
                    char c = (char)rnd.Next(1, 255);
                    s += c;
                }
                return s;
            }
            public void GetManualDocument()
            {
                DocData = new List<IPrintable>();
                bool isInputing = true;
                while (isInputing)
                {
                    Console.WriteLine("Выберите тип создаваемого элемента");
                    Console.WriteLine("1 - текст, 2 - таблица, 3 - цветной текст");
                    int v = Convert.ToInt32(Console.ReadLine());
                    switch (v)
                    {
                        case 1: Console.WriteLine("Введите текст"); DocData.Add(new Text(Console.ReadLine())); break;
                        case 2: Console.WriteLine("Введите число строк"); int h = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введите число столбцев"); int w = int.Parse(Console.ReadLine());
                            DocData.Add(new Table(h, w)); break;
                        case 3: Console.WriteLine("Введите текст");
                            string s = Console.ReadLine();
                            Console.WriteLine("Выберите цвет");
                            Console.WriteLine("1-red, 2-green, 3-blue");
                            int color = int.Parse(Console.ReadLine());
                            switch (color)
                            {
                                case 1: DocData.Add(new ColorText(s, ConsoleColor.Red)); break;

                                case 2: DocData.Add(new ColorText(s, ConsoleColor.Green)); break;

                                case 3: DocData.Add(new ColorText(s, ConsoleColor.Blue)); break;
                            } break;
                    }
                    Console.WriteLine("Ввод закончен?");
                    Console.WriteLine("1-да, 2-нет");
                    int res = int.Parse(Console.ReadLine());
                    if (res != 2) isInputing = false;
                }
            }
            public void GetRandomDocument(int size)
            {
                this.DocData = new List<IPrintable>();
                Random rnd = new Random();
                for (int i = 0; i < size; i++)
                {
                    DocData.Add(new Text());
                }
                for (int i = 0; i < DocData.Count; i++)
                {
                    int obj = rnd.Next(0, 3);
                    switch (obj)
                    {
                        case 0: DocData[i] = new Text(GenerateRandomText()); ; break;
                        case 1: DocData[i] = new Table(rnd.Next(2, 5), rnd.Next(2, 5)); break;
                        case 2: int color = rnd.Next(0, 3); ConsoleColor col = new ConsoleColor();
                            if (color == 0) col = ConsoleColor.Red;
                            if (color == 1) col = ConsoleColor.Green;
                            if (color == 2) col = col = ConsoleColor.Blue;
                            DocData[i] = new ColorText(GenerateRandomText(), col); break;
                    }
                }
            }
        }
        public interface IPrintable
        {
            void PrintInConsole();
        }
        public class Text : IPrintable
        {
            public string data;
            public Text()
            {
                data = string.Empty;
            }
            public Text(string s)
            {
                data = s;
            }
            public void PrintInConsole()
            {
                Console.WriteLine(data);
            }
        }
        public class Table : IPrintable
        {
            public int numHTable { get; set; }
            public int numWTable { get; set; }
            public Table(int h, int w)
            {
                this.numHTable = h;
                this.numWTable = w;
            }
            public void PrintInConsole()
            {
                for (int i = 0; i < this.numHTable; i++)
                {
                    int x = Console.CursorLeft;
                    int y = Console.CursorTop;
                    int x1 = x, y1 = y;
                    for (int j = 0; j < this.numWTable; j++)
                    {
                        Console.SetCursorPosition(x1, y1); Console.Write("*********");
                        Console.SetCursorPosition(x1, y1 + 1); Console.Write("*       *");
                        Console.SetCursorPosition(x1, y1 + 2); Console.Write("*********");
                        x1 += 9;
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
        public class ColorText : IPrintable
        {
            public ConsoleColor textColor;
            public string Data;
            public ColorText()
            {
                this.textColor = ConsoleColor.White;
                Data = string.Empty;
            }
            public ColorText(string s, ConsoleColor color)
            {
                this.textColor = color;
                this.Data = s;
            }
            public void PrintInConsole()
            {
                Console.ForegroundColor = this.textColor;
                Console.WriteLine(this.Data);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
