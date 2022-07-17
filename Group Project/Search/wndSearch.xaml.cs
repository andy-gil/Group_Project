using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Reflection;
using Group_Project.Main;
using System.Data;
using Group_Project;

namespace search
{
    /// <summary>
    /// Interaction logic for wndSearch.xaml
    /// </summary>
    public partial class wndSearch : Window
    {
        clsSearchLogic searchLogic;
        MainWindow ClsMainWindow;
        clsSearchSQL searchSQL;
        clsInvoice invoice;
        clsDataAccess db;
        DataSet ds;
        int iRet = 0;

        /// <summary>
        /// constructor
        /// </summary>
        public wndSearch()
        {
            db = new clsDataAccess();
            searchLogic = new clsSearchLogic();
            searchSQL = new clsSearchSQL();
            InitializeComponent();
            Application.Current.ShutdownMode = ShutdownMode.OnMainWindowClose;
            fillComboBox();
            fillDataGrid();
        }

            /// <summary>
            /// Select invoice button was clicked
            /// Whatever was selected should be stored
            /// the stored item will than be passed to the mainwindow
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void InvoiceSelected_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Hide();
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                    MethodInfo.GetCurrentMethod().Name, ex.Message);
            }

        }

        public void fillComboBox()
        {
            DataSet ds;
            int iRet = 0;
            ds = db.ExecuteSQLStatement("SELECT * FROM Invoices", ref iRet);

            //Loop through all the values returned
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                InvoiceNumCB.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
            
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                ds = db.ExecuteSQLStatement("SELECT * FROM Invoices ORDER BY TotalCost", ref iRet);
                InvoiceTotalGB.Items.Add(ds.Tables[0].Rows[i][2].ToString());
            }
            
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                //Add the first and last name to the list box
                InvoiceDateGB.Items.Add(ds.Tables[0].Rows[i][1].ToString());
            }
        }

        /// <summary>
        /// Full the data grid with the database
        /// </summary>
        private void fillDataGrid()
        {
            DataSet ds;
            db = new clsDataAccess();
            dataGridSearch.ItemsSource = searchLogic.GetGrid();
        }

        /// <summary>
        /// Cancel button
        /// Allows the user to exit the search window
        /// And goes back to the main window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Hide();
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                    MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        private void InvoiceNumCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //searchSQL.GetInvoices(InvoiceNumCB.SelectedIndex.ToString());
            //searchLogic.GetGrid() = InvoiceNumCB.SelectedItem;
            //dataGridSearch.ItemsSource = InvoiceNumCB.SelectedItem;
        }

        /// <summary>
        /// Clear filters was clicked
        /// Needs to reset the data grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearBtn_Click(object sender, RoutedEventArgs e)
        {
            //dataGridSearch = searchSQL.GetAllInvoices(sSQL);
            
        }

        /// <summary>
        /// Helps with the errors
        /// </summary>
        /// <param name="sClass"></param>
        /// <param name="sMethod"></param>
        /// <param name="sMessage"></param>
        private void HandleError(string sClass, string sMethod, string sMessage)
        {
            try
            {
                MessageBox.Show(sClass + "." + sMethod + "->" + sMessage);
            }
            catch (Exception ex)
            {
                System.IO.File.AppendAllText("C:\\Error.Txt", Environment.NewLine +
                    "HandleError Exception: " + ex.Message);
            }
        }

        /// <summary>
        /// For when the user uses the X button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Group_Project.InvoiceDataSet invoiceDataSet = ((Group_Project.InvoiceDataSet)(this.FindResource("invoiceDataSet")));
            // Load data into the table ItemDesc. You can modify this code as needed.
            Group_Project.InvoiceDataSetTableAdapters.ItemDescTableAdapter invoiceDataSetItemDescTableAdapter = new Group_Project.InvoiceDataSetTableAdapters.ItemDescTableAdapter();
            invoiceDataSetItemDescTableAdapter.Fill(invoiceDataSet.ItemDesc);
            System.Windows.Data.CollectionViewSource itemDescViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("itemDescViewSource")));
            itemDescViewSource.View.MoveCurrentToFirst();
            // Load data into the table Invoices. You can modify this code as needed.
            Group_Project.InvoiceDataSetTableAdapters.InvoicesTableAdapter invoiceDataSetInvoicesTableAdapter = new Group_Project.InvoiceDataSetTableAdapters.InvoicesTableAdapter();
            invoiceDataSetInvoicesTableAdapter.Fill(invoiceDataSet.Invoices);
            System.Windows.Data.CollectionViewSource invoicesViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("invoicesViewSource")));
            invoicesViewSource.View.MoveCurrentToFirst();
        }
    }
}
