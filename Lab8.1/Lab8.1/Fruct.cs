using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8._1
{
    class Fruct
    {
        private string where;
        private string name;
        private double cost;
        public void SetName(string name)
        {
            this.name = name;
        }
        private void SetCost(double cost)
        {
            this.cost = cost;
        }
        protected void SetWhere(string where)
        {
            this.where = where;
        }
        public string WRTLN()
        {
            return String.Format("name = {0} where = {1}", name, where);
        }
    }
}
