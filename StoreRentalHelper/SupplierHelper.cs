using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreRentalHelper
{
    public class SupplierHelper
    {
        #region Connection
        public static SqlConnection Connection { get; set; } = default!;

        #endregion

        #region Procedure and View Names
        private const string INSERT = "sp_InsertNewSupplier";
        private const string UPDATE = "sp_UpdateSupplier";
        private const string GET_ALL = "v_GetAllSuppliers";
        #endregion

        #region Generate Insert Supplier Command
        public static SqlCommand CreateInsertSupplierCommand()
        {
            var cmd = new SqlCommand(INSERT, Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@SupplierName ", SqlDbType.NVarChar, 50)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "SupplierName"
            });
            cmd.Parameters.Add(new SqlParameter("@ContactNumber", SqlDbType.NVarChar, 50)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "ContactNumber"
            });
            cmd.Parameters.Add(new SqlParameter("@SupplierAddress", SqlDbType.NVarChar, 255)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "SupplierAddress"
            });
            
            return cmd;
        }
        #endregion

        #region Generate Get All Suppliers Command
        public static SqlCommand CreateGetAllSuppliersCommand()
        {
            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = $"SELECT * FROM {GET_ALL}";
            return cmd;
        }
        #endregion

        #region Generate Update Supplier Command
        public static SqlCommand CreateUpdateSupplierCommand()
        {
            var cmd = new SqlCommand(UPDATE, Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@SupplierID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Original,
                SourceColumn = "SupplierID"
            });
            cmd.Parameters.Add(new SqlParameter("@SupplierName", SqlDbType.NVarChar, 50)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "SupplierName"
            });
            cmd.Parameters.Add(new SqlParameter("@ContactNumber", SqlDbType.NVarChar, 20)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "ContactNumber"
            });
            cmd.Parameters.Add(new SqlParameter("@SupplierAddress", SqlDbType.NVarChar, 255)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "SupplierAddress"
            });
           
            return cmd;
        }
        #endregion

    }
}
