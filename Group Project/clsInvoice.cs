using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Group_Project.Main
{
    public class clsInvoice
    {
        //constructor
        public clsInvoice(string sInvoiceNum, string sInvoiceDate, string dCost)
        {
            this.sInvoiceNum = sInvoiceNum;
            this.sInvoiceDate = sInvoiceDate;
            this.dCost = dCost;
        }


        /// <summary>
        /// Stores information for each invoice
        /// </summary>
        public string sInvoiceNum { get; set; }
        public string sInvoiceDate { get; set; }
        public string dCost { get; set; }

        public override string ToString()
        {
            return "Invoice Number: " + sInvoiceNum + ", Invoice Date: " + sInvoiceDate + ", Total Cost: $" + dCost;
        }
    }


}