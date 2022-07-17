using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Group_Project
{
    /// <summary>
    /// This class contains all SQL statements needed to retrieve data
    /// </summary>
    class clsMainSQL
    {

        /// <summary>
        /// SQL Statement that retrieves all data on an invoice for a given ID
        /// </summary>
        /// <param name="sInvoiceID"></param>
        /// <returns>All data for the given invoice</returns>
        public string SelectInvoiceData(string sInvoiceID)
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
        /// Contains SQL to retrieve a single Item from both the LineItems table and ItemDesc table
        /// </summary>
        /// <returns></returns>
        public string GetItem(string sInvoiceNum)
        {
            try
            {
                string sSQL = "SELECT LineItems.ItemCode, ItemDesc.ItemDesc, ItemDesc.Cost FROM LineItems, ItemDesc Where LineItems.ItemCode = ItemDesc.ItemCode And LineItems.InvoiceNum = " + sInvoiceNum;
                return sSQL;
            }
            catch (Exception ex)
            {

                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Gets all item descriptions, codes, and cost from ItemDesc table
        /// </summary>
        /// <returns></returns>
        public string GetAllItems()
        {
            try
            {
                string sSQL = "SELECT ItemCode, ItemDesc, Cost FROM ItemDesc";
                return sSQL;
            }
            catch (Exception ex)
            {

                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// This SQL retrieves a single invoice
        /// </summary>
        /// <param name="sInvoiceID"></param>
        /// <returns></returns>
        public string GetInvoice(string sInvoiceID)
        {
            try
            {
                string sSQL = "SELECT InvoiceNum, InvoiceDate, TotalCost FROM Invoices WHERE InvoiceNum = " + sInvoiceID;
                return sSQL;
            }
            catch (Exception ex)
            {

                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Contains SQL to add (insert) an invoice into the Invoices table
        /// </summary>
        /// <param name="sDate"></param>
        /// <param name="sCost"></param>
        /// <returns></returns>
        public string AddInvoice(string sDate, string sCost)
        {
            try
            {
                string sSQL = "INSERT INTO Invoices (InvoiceDate, TotalCost) Values ('#" + sDate + "#', " + sCost + ")";
                return sSQL;
            }
            catch (Exception ex)
            {

                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }
        /// <summary>
        /// Getting the MAX invoices
        /// </summary>
        /// <param name="sDate"></param>
        /// <param name="sCost"></param>
        /// <returns></returns>
        public string MaxInvoice()
        {
            try
            {
                string sSQL = "SELECT MAX(InvoiceNum) FROM Invoices";
                return sSQL;
            }
            catch (Exception ex)
            {

                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// SQL Statement that updates the total cost at a specific InvoiceID
        /// </summary>
        /// <param name="sCost"></param>
        /// <param name="sInvoiceID"></param>
        /// <returns>Statement for updating cost</returns>
        public string UpdateInvoiceCost(string sCost, string sInvoiceID)
        {
            try
            {
                string sSQL = "UPDATE Invoices SET TotalCost = " + sCost + " WHERE InvoiceNum = " + sInvoiceID;
                return sSQL;
            }
            catch (Exception ex)
            {

                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }
        /// <summary>
        /// This method contains the SQL statement to delete an Invoice
        /// </summary>
        /// <param name="sCost"></param>
        /// <param name="sInvoiceID"></param>
        /// <returns></returns>
        public string DeleteInvoice(string sInvoiceID)
        {
            try
            {
                string sSQL = "DELETE From Invoices WHERE InvoiceNum = " + sInvoiceID;
                return sSQL;
            }
            catch (Exception ex)
            {

                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// This method contains the SQL statement to delete an item from the LineItems table
        /// </summary>
        /// <param name="sInvoiceNum"></param>
        /// <returns></returns>
        public string DeleteItemInvoice(string sInvoiceNum)
        {
            try
            {
                string sSQL = "DELETE From LineItems WHERE InvoiceNum = " + sInvoiceNum;
                return sSQL;
            }
            catch (Exception ex)
            {

                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// This method adds an item to the LineItems table
        /// </summary>
        /// <param name="sInvoiceNum"></param>
        /// <param name="sLineItemNum"></param>
        /// <param name="sItemCode"></param>
        /// <returns></returns>
        public string AddItemInvoice(string sInvoiceNum, string sLineItemNum, string sItemCode)
        {
            try
            {
                string sSQL = "INSERT INTO LineItems (InvoiceNum, LineItemNum, ItemCode) Values (" + sLineItemNum + ", " + sLineItemNum + ", '" + sItemCode + "')";
                return sSQL;
            }
            catch (Exception ex)
            {

                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }
    }
}
