using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreRentalHelper
{
    public static class ContractHelper
    {
        public static SqlConnection Connection { get; set; } = default!;

        #region Procedure and View Names
        private const string INSERT = "spInsertNewContract";
        private const string UPDATE = "spUpdateContract";
        private const string GET_ALL = "vGetAllContracts";
        private const string GET_ALL_STAFFS_FOR_COMBO_BOX = "vGetAllStaffsForComboBox";
        private const string GET_ALL_INSURANCES_FOR_COMBO_BOX = "vGetAllInsurancesForComboBox";
        private const string GET_ALL_STORES_FOR_COMBO_BOX = "vGetAllFreeStoresForComboBox";
        private const string GET_ALL_CUSTOMERS_FOR_COMBO_BOX = "vGetAllCustomersForComboBox";
        #endregion

        #region Generate Insert Contract Command
        public static SqlCommand CreateInsertContractCommand()
        {
            var cmd = new SqlCommand(INSERT, Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ContractDate", SqlDbType.Date)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "ContractDate"
            });
            cmd.Parameters.Add(new SqlParameter("@LeaseStartDate", SqlDbType.Date)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "LeaseStartDate"
            });
            cmd.Parameters.Add(new SqlParameter("@LeaseEndDate", SqlDbType.Date)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "LeaseEndDate"
            });
            cmd.Parameters.Add(new SqlParameter("@NextPaymentDate", SqlDbType.Date)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "NextPaymentDate"
            });
            cmd.Parameters.Add(new SqlParameter("@StoreID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "StoreID"
            });
            cmd.Parameters.Add(new SqlParameter("@CustomerID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "CustomerID"
            });
            cmd.Parameters.Add(new SqlParameter("@InsuranceID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "InsuranceID"
            });
            cmd.Parameters.Add(new SqlParameter("@InsuranceName", SqlDbType.NVarChar, 50)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "InsuranceName"
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

        #region Generate Get All Contracts Command
        public static SqlCommand CreateGetAllContractsCommand()
        {
            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = $"SELECT * FROM {GET_ALL}";
            return cmd;
        }
        #endregion

        #region Generate Update Contract Command
        public static SqlCommand CreateUpdateContractCommand()
        {
            var cmd = new SqlCommand(UPDATE, Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ContractID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Original,
                SourceColumn = "ContractID"
            });
            cmd.Parameters.Add(new SqlParameter("@ContractDate", SqlDbType.Date)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "ContractDate"
            });
            cmd.Parameters.Add(new SqlParameter("@LeaseStartDate", SqlDbType.Date)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "LeaseStartDate"
            });
            cmd.Parameters.Add(new SqlParameter("@LeaseEndDate", SqlDbType.Date)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "LeaseEndDate"
            });
            cmd.Parameters.Add(new SqlParameter("@NextPaymentDate", SqlDbType.Date)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "NextPaymentDate"
            });
            cmd.Parameters.Add(new SqlParameter("@StoreID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "StoreID"
            });
            cmd.Parameters.Add(new SqlParameter("@CustomerID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "CustomerID"
            });
            cmd.Parameters.Add(new SqlParameter("@InsuranceID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "InsuranceID"
            });
            cmd.Parameters.Add(new SqlParameter("@InsuranceName", SqlDbType.NVarChar, 50)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "InsuranceName"
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
            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = $"SELECT * FROM {GET_ALL_STAFFS_FOR_COMBO_BOX}";
            return cmd;
        }
        #endregion

        #region Generate Get All Customers For Combo Box Command
        public static SqlCommand CreateGetAllCustomersForComboBoxCommand()
        {
            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = $"SELECT * FROM {GET_ALL_CUSTOMERS_FOR_COMBO_BOX}";
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

        #region Generate Get All Insurances For Combo Box Command
        public static SqlCommand CreateGetAllInsurancesForComboBoxCommand()
        {
            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = $"SELECT * FROM {GET_ALL_INSURANCES_FOR_COMBO_BOX}";
            return cmd;
        }
        #endregion
    }
}
