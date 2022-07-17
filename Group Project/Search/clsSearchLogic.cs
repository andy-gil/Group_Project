using Group_Project.Main;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace search
{
    public class clsSearchLogic
    {
        clsSearchSQL searchSQL;
        clsInvoice invoice;
        clsDataAccess DataAccess;
        DataSet ds;
        public clsSearchLogic()
        {
            searchSQL = new clsSearchSQL();
            DataAccess = new clsDataAccess();

        }


        public List<clsInvoice> GetGrid()
        {
            List<clsInvoice> Grid = new List<clsInvoice>();
            string sSql = "SELECT * FROM Invoices";
            int retVal = 0;

            ds = DataAccess.ExecuteSQLStatement(sSql, ref retVal);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Grid.Add(new clsInvoice(dr[0].ToString(), dr[1].ToString(), dr[2].ToString()));
            }

            return Grid;
        }
    }
}
