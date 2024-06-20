using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreRentalHelper
{
    public static class CustomerHelper
    {
        public static SqlConnection Connection { get; set; } = default!;

        #region Procedure and View Names
        private const string INSERT = "sp_InsertNewCustomer";
        private const string UPDATE = "sp_UpdateCustomer";
        private const string GET_ALL = "v_GetAllCustomers";
        #endregion

        #region Generate Insert Customer Command
        public static SqlCommand CreateInsertCustomerCommand()
        {
            var cmd = new SqlCommand(INSERT, Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@CustomerFirstName", SqlDbType.NVarChar, 50)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "CustomerFirstName"
            });
            cmd.Parameters.Add(new SqlParameter("@CustomerLastName", SqlDbType.NVarChar, 50)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "CustomerLastName"
            });
            cmd.Parameters.Add(new SqlParameter("@Sex", SqlDbType.Char, 1)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "Sex"
            });
            cmd.Parameters.Add(new SqlParameter("@BirthDate", SqlDbType.Date)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "BirthDate"
            });
            cmd.Parameters.Add(new SqlParameter("@IdentityCardNumber", SqlDbType.VarChar, 10)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "IdentityCardNumber"
            });
            cmd.Parameters.Add(new SqlParameter("@HouseNo", SqlDbType.NVarChar, 25)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "HouseNo"
            });
            cmd.Parameters.Add(new SqlParameter("@StreetNo", SqlDbType.NVarChar, 25)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "StreetNo"
            });
            cmd.Parameters.Add(new SqlParameter("@Sangkat", SqlDbType.NVarChar, 50)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "Sangkat"
            });
            cmd.Parameters.Add(new SqlParameter("@Khan", SqlDbType.NVarChar, 50)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "Khan"
            });
            cmd.Parameters.Add(new SqlParameter("@ProvinceOrCity", SqlDbType.NVarChar, 50)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "ProvinceOrCity"
            });
            cmd.Parameters.Add(new SqlParameter("@ContactNumber", SqlDbType.VarChar, 20)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "ContactNumber"
            });
            cmd.Parameters.Add(new SqlParameter("@Photo", SqlDbType.VarBinary, int.MaxValue)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "Photo"
            });

            return cmd;
        }
        #endregion

        #region Generate Get All Customers Command
        public static SqlCommand CreateGetAllCustomersCommand()
        {
            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = $"SELECT * FROM {GET_ALL}";
            return cmd;
        }
        #endregion

        #region Generate Update Customer Command
        public static SqlCommand CreateUpdateCustomerCommand()
        {
            var cmd = new SqlCommand(UPDATE, Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@CustomerID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Original,
                SourceColumn = "CustomerID"
            });
            cmd.Parameters.Add(new SqlParameter("@CustomerFirstName", SqlDbType.NVarChar, 50)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "CustomerFirstName"
            });
            cmd.Parameters.Add(new SqlParameter("@CustomerLastName", SqlDbType.NVarChar, 50)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "CustomerLastName"
            });
            cmd.Parameters.Add(new SqlParameter("@Sex", SqlDbType.Char, 1)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "Sex"
            });
            cmd.Parameters.Add(new SqlParameter("@BirthDate", SqlDbType.Date)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "BirthDate"
            });
            cmd.Parameters.Add(new SqlParameter("@IdentityCardNumber", SqlDbType.VarChar, 10)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "IdentityCardNumber"
            });
            cmd.Parameters.Add(new SqlParameter("@HouseNo", SqlDbType.NVarChar, 25)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "HouseNo"
            });
            cmd.Parameters.Add(new SqlParameter("@StreetNo", SqlDbType.NVarChar, 25)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "StreetNo"
            });
            cmd.Parameters.Add(new SqlParameter("@Sangkat", SqlDbType.NVarChar, 50)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "Sangkat"
            });
            cmd.Parameters.Add(new SqlParameter("@Khan", SqlDbType.NVarChar, 50)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "Khan"
            });
            cmd.Parameters.Add(new SqlParameter("@ProvinceOrCity", SqlDbType.NVarChar, 50)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "ProvinceOrCity"
            });
            cmd.Parameters.Add(new SqlParameter("@ContactNumber", SqlDbType.VarChar, 20)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "ContactNumber"
            });
            cmd.Parameters.Add(new SqlParameter("@Photo", SqlDbType.VarBinary, int.MaxValue)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "Photo"
            });

            return cmd;
        }
        #endregion
    }
}
