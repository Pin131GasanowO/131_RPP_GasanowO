using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8._1
{
    class Apple : Fruct
    {
        private string Sort;
        public Apple(string nameApp, /* double cost */ string whereApp)
        {
            SetName(nameApp);
            //SetCost(5.00);
            SetWhere(whereApp);
        }
    }
}
