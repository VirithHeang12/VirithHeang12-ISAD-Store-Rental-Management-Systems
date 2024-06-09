using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreRentalHelper
{
    public static class ExpenseTypeHelper
    {
        #region Connection
        public static SqlConnection Connection { get; set; } = default!;
        #endregion

        #region Procedure and View Names
        private const string INSERT = "sp_InsertNewExpenseType";
        private const string UPDATE = "sp_UpdateExpenseType";
        private const string GET_ALL = "v_GetAllExpenseTypes";
        #endregion

        #region Generate Insert ExpenseType Command
        public static SqlCommand CreateInsertExpenseTypeCommand()
        {
            var cmd = new SqlCommand(INSERT, Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ExpenseDescription", SqlDbType.NVarChar, 255)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "ExpenseDescription"
            });
           

            return cmd;
        }
        #endregion

        #region Generate Get All ExpenseType Command
        public static SqlCommand CreateGetAllExpenseTypesCommand()
        {
            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = $"SELECT * FROM {GET_ALL}";
            return cmd;
        }
        #endregion

        #region Generate Update ExpenseType Command
        public static SqlCommand CreateUpdateExpenseTypeCommand()
        {
            var cmd = new SqlCommand(UPDATE, Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ExpenseTypeID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Original,
                SourceColumn = "ExpenseTypeID"
            });
            cmd.Parameters.Add(new SqlParameter("@ExpenseDescription", SqlDbType.NVarChar, 255)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "ExpenseDescription"
            });
           
            return cmd;
        }
        #endregion
    }
}
