
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using search;
using System.Reflection;



namespace Group_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Storing MainLogic class
        /// </summary>
        clsMainLogic ClsMainLogic;
        /// <summary>
        /// Storing SQL Statement class
        /// </summary>
        clsMainSQL ClsMainSQL;
        /// <summary>
        /// Storing Search Window class
        /// </summary>
        wndSearch wndSearch;
        /// <summary>
        /// This class represents the main window that is displayed to the user upon program start. For now, 
        /// the only functionality is the search button which, when clicked, displays the search window. For now, this class represents the UI
        /// that will be used for the final product.
        /// </summary>
        public MainWindow()
        {
           
            InitializeComponent();
            ClsMainLogic = new clsMainLogic();
            ClsMainSQL = new clsMainSQL();
            Application.Current.ShutdownMode = ShutdownMode.OnMainWindowClose; ///Making sure program can shutdown properly

        }

        /// <summary>
        /// This method brings up the search menu for the user to search for an invoice or item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ///To pass data to the search menu, this method will initialize the search window and pass data by constructor from a class that contains
                ///invoices. Once the search menu is closed, a method call will take place that repopulates items back into the main window
                ///For now the button simply displays the search window
                ///
                wndSearch = new wndSearch();
                this.Hide();
                wndSearch.ShowDialog();
                this.Show();
            }
            catch (Exception ex)
            {
                ///Top Level
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }
        /// <summary>
        /// Method for exception handling
        /// </summary>
        /// <param name="sClass"></param>
        /// <param name="sMethod"></param>
        /// <param name="sMessage"></param>
        private void HandleError(string sClass, string sMethod, string sMessage)
        {
            try
            {
                MessageBox.Show(sClass + "." + sMethod + " -> " + sMessage);
            }
            catch (Exception ex)
            {

                System.IO.File.AppendAllText("C:\\Error.txt", Environment.NewLine +
                    "HandleError Exception: " + ex.Message);
            }
        }
    }
}
