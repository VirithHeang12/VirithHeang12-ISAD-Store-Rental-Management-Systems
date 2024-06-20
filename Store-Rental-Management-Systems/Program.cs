using StoreRentalLib;
using Microsoft.Data.SqlClient;
using StoreRentalHelper;
using System.Data;

namespace Store_Rental_Management_Systems
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            TryConnectingToServer();
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmMain());
        }

        static void TryConnectingToServer()
        {
            StoreRentalLib.Connection.ConnectionStringKey = "ConnectionString";
            try
            {
                StoreRentalLib.Connection.LoadConfiguration("appsettings.json");
                StoreRentalLib.Connection.Conn = Connection;
                Connection = StoreRentalLib.Connection.OpenConnection();
                InitCommands();
                StoreRentalLib.Connection.CloseConnnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Preparing a connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }
        public static SqlConnection Connection = default!;
        private static void InitCommands()
        {
            StaffHelper.Connection = Connection;
            InsuranceHelper.Connection = Connection;
            StoreTypeHelper.Connection = Connection;
            ExpenseTypeHelper.Connection = Connection;
            SupplierHelper.Connection = Connection;
            ImportHelper.Connection = Connection;
            ItemHelper.Connection = Connection;

            UserHelper.Connection = Connection;

            SalaryPaymentHelper.Connection = Connection;
            StoreHelper.Connection = Connection;
            LoginHelper.Connection = Connection;

        }
    }
}