using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Project.Main
{
    public class clsShoe
    {
        public string sShoeID { get; set; }
        public string sShoeName { get; set; }
        public double dCost { get; set; }

        public override string ToString()
        {
            return sShoeName + " : " + "$" + dCost;
        }
    }
}
