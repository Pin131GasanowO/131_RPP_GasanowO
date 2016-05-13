using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Automobile
    {
        protected string name, model, color, body, country;
        public Automobile()
        {
            name = "";
            model = "";
            color = "";
            body = "";
            country = "";
        }
        public Automobile(string Name, string Model, string Color, string Body, string Country)
        {
            name = Name;
            model = Model;
            color = Color;
            body = Body;
            country = Country;
        }
        public string GetPTS()
        {
            string ret = name;
            if (model != "") ret += " " + model.ToUpper() + ". ";
            if (color != "") ret += " " + color.ToUpper() + ". ";
            if (body != "") ret += " " + body.ToUpper() + ". ";
            if (country != "") ret += " " + country.ToUpper() + ". ";
            return ret;
        }
    }
    class Stolen_car : Automobile
    {
        string body_number;
        public Stolen_car()
        {
            body_number = "";   
        }
        public Stolen_car(string Name, string Model, string Color, string Body, string Country, string Body_number) 
            : base (Name, Model, Color, Body, Country)
        {
            body_number = Body_number;
        }
        public string GetBody_number()
        {
            return body_number;
        }
    }
    class New_car : Automobile
        {
        string contract_number;
        public New_car()
        {
            contract_number = "";   
        }
        public New_car(string Name, string Model, string Color, string Body, string Country, string Contract_number) 
            : base (Name, Model, Color, Body, Country)
        {
            contract_number = Contract_number;
        }
        public string GetContract_number()
        {
            return contract_number;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            New_car x1 = new New_car("Porsche", "Cayman`s", "White", "Coupe", "Germany", "0007896542");
            Stolen_car x2 = new Stolen_car("Lada", "Granta", "Dark blue", "Sedan", "Russia", "45378609753265789453");
            New_car x3 = new New_car("Ferrari", "Enzo", "Red", "Coupe", "Italy", "0006942754");
            Stolen_car x4 = new Stolen_car("Fiat", "Punto", "Green", "Hatchback", "France", "13769527584233678014");
            New_car x5 = new New_car("Nissan", "Skyline", "Gray", "Coupe", "Japan", "0003427584");
            Stolen_car x6 = new Stolen_car("Audi", "R8", "Brown", "Coupe", "Germany", "75543627689084736474");
            New_car x7 = new New_car("Shelby", "GT500", "Black", "Coupe", "America", "0008923574");
            Stolen_car x8 = new Stolen_car("Ford", "Focus", "Orange", "Hatchback", "America", "64783834764647847363");
            New_car x9 = new New_car("Shelby", "GT500 1967", "Black", "Coupe", "America", "0008706857");
            Stolen_car x10 = new Stolen_car("Kia", "Cerato", "Yellow", "Sedan", "Korea", "5647893387363536478");
            Console.WriteLine("New cars:");
            Console.WriteLine("");
            Console.WriteLine("Automobile PTS: {0}", x1.GetPTS());
            Console.WriteLine("Contract_number: {0}",x1.GetContract_number());
            Console.WriteLine("");
            Console.WriteLine("Automobile PTS: {0}", x3.GetPTS());
            Console.WriteLine("Contract_number: {0}", x3.GetContract_number());
            Console.WriteLine("");
            Console.WriteLine("Automobile PTS: {0}", x5.GetPTS());
            Console.WriteLine("Contract_number: {0}", x5.GetContract_number());
            Console.WriteLine("");
            Console.WriteLine("Automobile PTS: {0}", x7.GetPTS());
            Console.WriteLine("Contract_number: {0}", x7.GetContract_number());
            Console.WriteLine("");
            Console.WriteLine("Automobile PTS: {0}", x9.GetPTS());
            Console.WriteLine("Contract_number: {0}", x9.GetContract_number());
            Console.WriteLine("");
            Console.WriteLine("Stolen cars:");
            Console.WriteLine("");
            Console.WriteLine("Automobile PTS: {0}", x2.GetPTS());
            Console.WriteLine("Body_number: {0}", x2.GetBody_number());
            Console.WriteLine("");
            Console.WriteLine("Automobile PTS: {0}", x4.GetPTS());
            Console.WriteLine("Body_number: {0}", x4.GetBody_number());
            Console.WriteLine("");
            Console.WriteLine("Automobile PTS: {0}", x6.GetPTS());
            Console.WriteLine("Body_number: {0}", x6.GetBody_number());
            Console.WriteLine("");
            Console.WriteLine("Automobile PTS: {0}", x8.GetPTS());
            Console.WriteLine("Body_number: {0}", x8.GetBody_number());
            Console.WriteLine("");
            Console.WriteLine("Automobile PTS: {0}", x10.GetPTS());
            Console.WriteLine("Body_number: {0}", x10.GetBody_number());
            Console.ReadKey();
        }
    }
}
