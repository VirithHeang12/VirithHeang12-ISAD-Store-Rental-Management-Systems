using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreRentalHelper
{
    public static class MaintenanceHelper
    {
        #region Connection
        public static SqlConnection Connection { get; set; } = default!;
        #endregion

        #region Procedure and View Names
        private const string INSERT_MAINTENANCE = "spInsertNewOrUpdateMaintenance";
        private const string GET_ALL_MAINTENANCES = "vGetAllMaintenances";
        private const string GET_ALL_MAINTENANCE_DETAILS = "vGetAllMaintenanceDetails";

        private const string GET_ALL_STORES_FOR_COMBO_BOX = "vGetAllStoresForComboBox";
        private const string GET_ALL_CONTRACTS_FOR_COMBO_BOX = "vGetAllContractsForComboBox";
        private const string GET_ALL_STAFFS_FOR_COMBO_BOX = "vGetAllStaffsForComboBox";
        private const string GET_ALL_ITEMS_FOR_COMBO_BOX = "vGetAllItemsForComboBox";
        #endregion

        #region Generate Insert or Update Maintenance Command
        public static SqlCommand CreateInsertOrUpdateMaintenanceCommand()
        {
            var cmd = new SqlCommand(INSERT_MAINTENANCE, Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaintenanceID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "MaintenanceID"
            });
            cmd.Parameters.Add(new SqlParameter("@MaintenanceDate", SqlDbType.Date)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "MaintenanceDate"
            });
            cmd.Parameters.Add(new SqlParameter("@TotalAmount", SqlDbType.Money)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "TotalAmount"
            });
            cmd.Parameters.Add(new SqlParameter("@PaidAmount", SqlDbType.Money)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "PaidAmount"
            });
            cmd.Parameters.Add(new SqlParameter("@OwedAmount", SqlDbType.Money)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "OwedAmount"
            });
            cmd.Parameters.Add(new SqlParameter("@StoreID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "StoreID"
            });
            cmd.Parameters.Add(new SqlParameter("@ContractID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "ContractID"
            });

            cmd.Parameters.Add(new SqlParameter("@StaffID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "StaffID"
            });
            cmd.Parameters.Add(new SqlParameter("@StaffName", SqlDbType.NVarChar, 100)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "StaffName"
            });
            cmd.Parameters.Add(new SqlParameter("@StaffPosition", SqlDbType.NVarChar, 100)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "StaffPosition"
            });
            cmd.Parameters.Add(new SqlParameter("@MaintenanceDetails", SqlDbType.Structured)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
            });
            return cmd;
        }
        #endregion

        #region Generate Get All Maintenances Command
        public static SqlCommand CreateGetAllMaintenancesCommand()
        {
            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = $"SELECT * FROM {GET_ALL_MAINTENANCES}";
            return cmd;
        }
        #endregion

        #region Generate Get All Maintenance Details Command
        public static SqlCommand CreateGetAllMaintenanceDetailsCommand()
        {
            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = $"SELECT * FROM {GET_ALL_MAINTENANCE_DETAILS}";
            return cmd;
        }
        #endregion

        #region Generate Get All Stores For Combo Box Command
        public static SqlCommand CreateGetAllStoresForComboBoxCommand()
        {
            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = $"SELECT * FROM {GET_ALL_STORES_FOR_COMBO_BOX}";
            return cmd;
        }
        #endregion

        #region Generate Get All Contracts For Combo Box Command
        public static SqlCommand CreateGetAllContractsForComboBoxCommand()
        {
            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = $"SELECT * FROM {GET_ALL_CONTRACTS_FOR_COMBO_BOX}";
            return cmd;
        }
        #endregion

        #region Generate Get All Staffs For Combo Box Command
        public static SqlCommand CreateGetAllStaffsForComboBoxCommand()
        {
            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = $"SELECT * FROM {GET_ALL_STAFFS_FOR_COMBO_BOX}";
            return cmd;
        }
        #endregion

        #region Generate Get All Items For Combo Box Command
        public static SqlCommand CreateGetAllItemsForComboBoxCommand()
        {
            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = $"SELECT * FROM {GET_ALL_ITEMS_FOR_COMBO_BOX}";
            return cmd;
        }
        #endregion
    }
}
