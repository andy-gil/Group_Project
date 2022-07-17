using Group_Project.Main;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace search
{
    /// <summary>
    /// SQL statements for the search
    /// </summary>
    class clsSearchSQL
    {
        wndSearch SearchCls;
        clsInvoice invoice;
        clsDataAccess db;
        DataSet ds;
        int iRet = 0;

        string sAllInvoices;
        string sAllInvoiceNum;

        public clsSearchSQL()
        {
            try
            {
                db = new clsDataAccess();
            }
            catch (Exception ex)
            {

                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// retrieves all results from invoice
        /// </summary>
        /// <returns></returns>
        public string GetAllInvoices()
        {
            try
            {
                string sSQL = "SELECT * FROM Invoices";
                return sSQL;
            }
            catch (Exception ex)
            {

                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// retrieve an invoice
        /// </summary>
        /// <param name="sInvoiceID"></param>
        /// <returns></returns>
        public string GetInvoices(string sInvoiceID)
        {
            try
            {
                string sSQL = "SELECT * FROM Invoices WHERE InvoiceNum = " + sInvoiceID;
                return sSQL;
            }
            catch (Exception ex)
            {

                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// retrieves specific invoice number and date
        /// </summary>
        /// <param name="sInvoiceID"></param>
        /// <param name="sDate"></param>
        /// <returns></returns>
        public string GetInvoicesDate(string sInvoiceID, string sDate)
        {
            try
            {
                string sSQL = "SELECT * FROM Invoices WHERE InvoiceNum = " + sInvoiceID + " AND Invoice Date = " + "#" + sDate + "#";
                return sSQL;
            }
            catch (Exception ex)
            {

                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }
        
        /// <summary>
        /// Retrieves specific invoice num, date, and cost
        /// </summary>
        /// <param name="sInvoiceID"></param>
        /// <param name="sDate"></param>
        /// <param name="sCost"></param>
        /// <returns></returns>
        public string GetInvoicesDateCost(string sInvoiceID, string sDate, string sCost)
        {
            try
            {
                string sSQL = "SELECT * FROM Invoices WHERE InvoiceNum = " + sInvoiceID + " AND " + "#" + sDate+ "#"
                    + " AND " + sCost;
                return sSQL;
            }
            catch (Exception ex)
            {

                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// SQL to search with cost only
        /// </summary>
        /// <param name="sCost"></param>
        /// <returns></returns>
        public string SearchCost(string sCost)
        {
            try
            {
                string sSQL = "SELECT * FROM Invoices WHERE TotalCost = " + sCost;
                return sSQL;
            }
            catch (Exception ex)
            {

                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                 MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// SQL Statement to search using both cost and date
        /// </summary>
        /// <param name="sCost"></param>
        /// <param name="sDate"></param>
        /// <returns></returns>
        public string SearchCostAndDate(string sCost, string sDate)
        {
            try
            {
                string sSQL = "SELECT * FROM Invoices WHERE TotalCost = " + sCost + "AND InvoiceDate = #" + sDate + "#";
                return sSQL;
            }
            catch (Exception ex)
            {

                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                 MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// SQL Statement to search using date only
        /// </summary>
        /// <param name="sDate"></param>
        /// <returns></returns>
        public string SearchDate(string sDate)
        {
            try
            {
                string sSQL = "SELECT * FROM Invoices WHERE InvoiceDate = #" + sDate + "#";
                return sSQL;
            }
            catch (Exception ex)
            {

                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                 MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        public List<int> GetInvoiceNumbers()
        {
            try
            {
                List<int> numbers = new List<int>();
                string get = "SELECT InvoiceNum FROM Invoices";

                int retVal = 0;
                ds = db.ExecuteSQLStatement(get, ref retVal);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    numbers.Add(Convert.ToInt32(dr[0]));
                }

                return numbers;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " --> " + ex.Message);
            }
        }
    }
}
