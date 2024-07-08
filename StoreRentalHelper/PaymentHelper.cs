using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreRentalHelper
{
    public static class PaymentHelper
    {
        #region Connection
        public static SqlConnection Connection { get; set; } = default!;
        #endregion

        #region Procedure and View Names
        private const string INSERT_PAYMENT = "spInsertNewOrUpdatePayment";
        private const string GET_ALL_PAYMENTS = "vGetAllPayments";

        private const string GET_ALL_PAYMENT_DETAILS = "vGetAllPaymentDetails";

        private const string GET_ALL_STORES_FOR_COMBO_BOX = "vGetAllStoresForComboBox";
        private const string GET_ALL_CONTRACTS_FOR_COMBO_BOX = "vGetAllContractsForComboBox";
        private const string GET_ALL_STAFFS_FOR_COMBO_BOX = "vGetAllStaffsForComboBox";
        private const string GET_ALL_EXPENSETYPES_FOR_COMBO_BOX = "vGetAllExpenseTypesForComboBox";
        #endregion

        #region Generate Insert or Update Payment Command
        public static SqlCommand CreateInsertOrUpdatePaymentCommand()
        {
            var cmd = new SqlCommand(INSERT_PAYMENT, Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@PaymentID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "PaymentID"
            });
            cmd.Parameters.Add(new SqlParameter("@PaymentDate", SqlDbType.Date)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "PaymentDate"
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
            cmd.Parameters.Add(new SqlParameter("@PaymentDetails", SqlDbType.Structured)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
            });
            return cmd;
        }
        #endregion

        #region Generate Get All Payments Command
        public static SqlCommand CreateGetAllPaymentsCommand()
        {
            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = $"SELECT * FROM {GET_ALL_PAYMENTS}";
            return cmd;
        }
        #endregion

        #region Generate Get All Payment Details Command
        public static SqlCommand CreateGetAllPaymentDetailsCommand()
        {
            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = $"SELECT * FROM {GET_ALL_PAYMENT_DETAILS}";
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

        #region Generate Get All ExpenseTypes For Combo Box Command
        public static SqlCommand CreateGetAllExpenseTypesForComboBoxCommand()
        {
            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = $"SELECT * FROM {GET_ALL_EXPENSETYPES_FOR_COMBO_BOX}";
            return cmd;
        }
        #endregion

    }
}
