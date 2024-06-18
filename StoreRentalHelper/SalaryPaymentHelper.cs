using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreRentalHelper
{
    public class SalaryPaymentHelper
    {
        #region Connection
        public static SqlConnection Connection { get; set; } = default!;

        #endregion

        #region Procedure and View Names
        private const string INSERT = "sp_InsertNewSalaryPayment";
        private const string UPDATE = "sp_UpdateSalaryPayment";
        private const string GET_ALL = "v_GetAllSalaryPayments";
        #endregion

        #region Generate Insert SalaryPayment Command
        public static SqlCommand CreateInsertSalaryPaymentCommand()
        {
            var cmd = new SqlCommand(INSERT, Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@SalaryPaymentDate", SqlDbType.DateTime)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "SalaryPaymentDate"
            });
            cmd.Parameters.Add(new SqlParameter("@SalaryPaymentAmount", SqlDbType.Money)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "SalaryPaymentAmount"
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

        #region Generate Get All SalaryPayments Command
        public static SqlCommand CreateGetAllSalaryPaymentsCommand()
        {
            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = $"SELECT * FROM {GET_ALL}";
            return cmd;
        }
        #endregion

        #region Generate Update SalaryPayment Command
        public static SqlCommand CreateUpdateSalaryPaymentCommand()
        {
            var cmd = new SqlCommand(UPDATE, Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@SalaryPaymentID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Original,
                SourceColumn = "SalaryPaymentID"
            });
            cmd.Parameters.Add(new SqlParameter("@SalaryPaymentDate", SqlDbType.DateTime)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "SalaryPaymentDate"
            });
            cmd.Parameters.Add(new SqlParameter("@SalaryPaymentAmount", SqlDbType.Money)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "SalaryPaymentAmount"
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

        #region Generate Get All Staffs For Combo Box Command
        public static SqlCommand CreateGetAllStaffsForComboBoxCommand()
        {
            return ImportHelper.CreateGetAllStaffsForComboBoxCommand();
        }
        #endregion

    }
}
