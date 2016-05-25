using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8._1
{
    class Berry : Fruct
    {
        private enum ColorBerry { Red = 1, Black = 2, Blue = 3, Green = 4 };
        public Berry(string name, string where)
        {
            SetName("Это ягода");
            SetWhere("куст");
        }
    }
}
