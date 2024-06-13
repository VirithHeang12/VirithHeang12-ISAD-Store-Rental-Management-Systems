using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreRentalHelper
{
    public static class ImportHelper
    {
        #region Connection
        public static SqlConnection Connection { get; set; } = default!;
        #endregion

        #region Procedure and View Names
        private const string INSERT_IMPORT = "sp_InsertNewImport";
        private const string UPDATE_IMPORT = "sp_UpdateImport";
        private const string GET_ALL_IMPORTS = "v_GetAllImports";

        private const string INSERT_IMPORT_DETAIL = "sp_InsertNewImportDetail";
        private const string UPDATE_IMPORT_DETAIL = "sp_UpdateImportDetail";
        private const string GET_ALL_IMPORT_DETAILS = "v_GetAllImportDetails";

        private const string GET_ALL_SUPPLIERS_FOR_COMBO_BOX = "v_GetAllSuppliersForComboBox";
        private const string GET_ALL_STAFFS_FOR_COMBO_BOX = "v_GetAllStaffsForComboBox";
        private const string GET_ALL_ITEMS_FOR_COMBO_BOX = "v_GetAllItemsForComboBox";
        #endregion

        #region Generate Insert Import Command
        public static SqlCommand CreateInsertImportCommand()
        {
            var cmd = new SqlCommand(INSERT_IMPORT, Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ImportDate", SqlDbType.Date)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "ImportDate"
            });
            cmd.Parameters.Add(new SqlParameter("@TotalAmount", SqlDbType.Money)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "TotalAmount"
            });
            cmd.Parameters.Add(new SqlParameter("@SupplierID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "SupplierID"
            });
            cmd.Parameters.Add(new SqlParameter("@SupplierName", SqlDbType.NVarChar, 50)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "SupplierName"
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
            return cmd;
        }
        #endregion

        #region Generate Update Import Command
        public static SqlCommand CreateUpdateImportCommand()
        {
            var cmd = new SqlCommand(UPDATE_IMPORT, Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ImportID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Original,
                SourceColumn = "ImportID"
            });
            cmd.Parameters.Add(new SqlParameter("@ImportDate", SqlDbType.Date)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "ImportDate"
            });
            cmd.Parameters.Add(new SqlParameter("@TotalAmount", SqlDbType.Money)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "TotalAmount"
            });
            cmd.Parameters.Add(new SqlParameter("@SupplierID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "SupplierID"
            });
            cmd.Parameters.Add(new SqlParameter("@SupplierName", SqlDbType.NVarChar, 50)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "SupplierName"
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

            return cmd;
        }
        #endregion

        #region Generate Get All Imports Command
        public static SqlCommand CreateGetAllImportsCommand()
        {
            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = $"SELECT * FROM {GET_ALL_IMPORTS}";
            return cmd;
        }
        #endregion

        #region Generate Insert Import Detail Command
        public static SqlCommand CreateInsertImportDetailCommand()
        {
            var cmd = new SqlCommand(INSERT_IMPORT_DETAIL, Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ImportID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "ImportID"
            });
            cmd.Parameters.Add(new SqlParameter("@ItemID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "ItemID"
            });
            cmd.Parameters.Add(new SqlParameter("@Description", SqlDbType.NVarChar, 255)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "Description"
            });
            cmd.Parameters.Add(new SqlParameter("@ImportQty", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "ImportQty"
            });
            cmd.Parameters.Add(new SqlParameter("@UnitPrice", SqlDbType.Money)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "UnitPrice"
            });
            cmd.Parameters.Add(new SqlParameter("@Amount", SqlDbType.Money)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "Amount"
            });
            return cmd;
        }
        #endregion

        #region Generate Update Import Detail Command
        public static SqlCommand CreateUpdateImportDetailCommand()
        {
            var cmd = new SqlCommand(UPDATE_IMPORT_DETAIL, Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ImportID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Original,
                SourceColumn = "ImportID"
            });
            cmd.Parameters.Add(new SqlParameter("@ItemID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "ItemID"
            });
            cmd.Parameters.Add(new SqlParameter("@Description", SqlDbType.NVarChar, 255)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "Description"
            });
            cmd.Parameters.Add(new SqlParameter("@ImportQty", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "ImportQty"
            });
            cmd.Parameters.Add(new SqlParameter("@UnitPrice", SqlDbType.Money)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "UnitPrice"
            });
            cmd.Parameters.Add(new SqlParameter("@Amount", SqlDbType.Money)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "Amount"
            });
            return cmd;
        }
        #endregion

        #region Generate Get All Import Details Command
        public static SqlCommand CreateGetAllImportDetailsCommand()
        {
            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = $"SELECT * FROM {GET_ALL_IMPORT_DETAILS}";
            return cmd;
        }
        #endregion

        #region Generate Get All Suppliers For Combo Box Command
        public static SqlCommand CreateGetAllSuppliersForComboBoxCommand()
        {
            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = $"SELECT * FROM {GET_ALL_SUPPLIERS_FOR_COMBO_BOX}";
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
