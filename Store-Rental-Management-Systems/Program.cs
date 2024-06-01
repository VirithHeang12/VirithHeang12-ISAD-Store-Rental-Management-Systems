using StoreRentalLib;
using Microsoft.Data.SqlClient;
using StoreRentalHelper;

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
            ConnectToServer();
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmMain());
        }

        static void ConnectToServer()
        {
            StoreRentalLib.Connection.ConnectionStringKey = "ConnectionString";
            try
            {
                StoreRentalLib.Connection.LoadConfiguration("appsettings.json");
                Connection = StoreRentalLib.Connection.OpenConnection();
                InitStaffCommands(Connection);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connecting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }
        public static SqlConnection Connection = default!;
        private static void InitStaffCommands(SqlConnection connection)
        {
            StaffHelper.Connection = connection;
            StaffHelper.GenerateCommands();
        }
    }
}