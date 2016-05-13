using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Apple : Fruct
    {
        private string Sort;
        public Apple (string nameApp, /* double cost, */ string whereApp)
        {
            SetName(nameApp);
            SetWhere(whereApp);
        }
    }
}
