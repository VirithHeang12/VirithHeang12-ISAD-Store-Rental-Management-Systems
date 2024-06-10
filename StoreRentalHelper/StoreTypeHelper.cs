using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreRentalHelper
{
    public static class StoreTypeHelper
    {

        #region Connection
        public static SqlConnection Connection { get; set; } = default!;
        #endregion

        #region Procedure and View Names
        private const string INSERT = "sp_InsertNewStoreType";
        private const string UPDATE = "sp_UpdateStoreType";
        private const string GET_ALL = "v_GetAllStoreTypes";
        #endregion

        #region Generate Insert StoreType Command
        public static SqlCommand CreateInsertStoreTypeCommand()
        {
            var cmd = new SqlCommand(INSERT, Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@StoreTypeDescription", SqlDbType.NVarChar, 255)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "StoreTypeDescription"
            });
            cmd.Parameters.Add(new SqlParameter("@MonthlyLeasePrice", SqlDbType.Money)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "MonthlyLeasePrice"
            });
            cmd.Parameters.Add(new SqlParameter("@ThreeMonthPaymentDiscount", SqlDbType.TinyInt)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "ThreeMonthPaymentDiscount"
            });
            cmd.Parameters.Add(new SqlParameter("@SixMonthPaymentDiscount", SqlDbType.TinyInt)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "SixMonthPaymentDiscount"
            });
            cmd.Parameters.Add(new SqlParameter("@OneYearPaymentDiscount", SqlDbType.TinyInt)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "OneYearPaymentDiscount"
            });

            return cmd;
        }
        #endregion

        #region Generate Get All StoreTypes Command
        public static SqlCommand CreateGetAllStoreTypesCommand()
        {
            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = $"SELECT * FROM {GET_ALL}";
            return cmd;
        }
        #endregion

        #region Generate Update StoreType Command
        public static SqlCommand CreateUpdateStoreTypeCommand()
        {
            var cmd = new SqlCommand(UPDATE, Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@StoreTypeID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Original,
                SourceColumn = "StoreTypeID"
            });
            cmd.Parameters.Add(new SqlParameter("@StoreTypeDescription", SqlDbType.NVarChar, 255)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "StoreTypeDescription"
            });
            cmd.Parameters.Add(new SqlParameter("@MonthlyLeasePrice", SqlDbType.Money)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "MonthlyLeasePrice"
            });
            cmd.Parameters.Add(new SqlParameter("@ThreeMonthPaymentDiscount", SqlDbType.TinyInt)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "ThreeMonthPaymentDiscount"
            });
            cmd.Parameters.Add(new SqlParameter("@SixMonthPaymentDiscount", SqlDbType.TinyInt)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "SixMonthPaymentDiscount"
            });
            cmd.Parameters.Add(new SqlParameter("@OneYearPaymentDiscount", SqlDbType.TinyInt)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "OneYearPaymentDiscount"
            });

            return cmd;
        }
        #endregion
    }
}
