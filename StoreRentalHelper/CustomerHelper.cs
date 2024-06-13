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
        #region events
        public static event EventHandler? Added;
        public static event EventHandler? Updated;
        public static event EventHandler? Deleted;
        #endregion

        #region Constants
        public static SqlConnection? Connection { get; set; }
        #endregion

        #region Procedure Names
        private const string INSERT_CUSTOMER = "sp_InsertNewCustomer";
        private const string UPDATE_CUSTOMER = "sp_UpdateCustomer";
        private const string DELETE_CUSTOMER = "sp_DeleteCustomer";
        private const string GET_ALL_CUSTOMERS = "v_GetAllCustomers";
        #endregion

        #region Commands
        private static Dictionary<string, SqlCommand> commands = new();
        #endregion

        #region Generate Insert Customer Command
        private static void CreateInsertCustomerCommand()
        {
            var cmd = new SqlCommand(INSERT_CUSTOMER, Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@CustomerFirstName", SqlDbType.NVarChar, 50)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false
            });
            cmd.Parameters.Add(new SqlParameter("@CustomerLastName", SqlDbType.NVarChar, 50)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false
            });
            cmd.Parameters.Add(new SqlParameter("@Sex", SqlDbType.Char, 1)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false
            });
            cmd.Parameters.Add(new SqlParameter("@BirthDate", SqlDbType.Date)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false
            });
            cmd.Parameters.Add(new SqlParameter("@IdentityCardNumber", SqlDbType.VarChar, 10)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false
            });
            cmd.Parameters.Add(new SqlParameter("@HouseNo", SqlDbType.NVarChar, 25)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false
            });
            cmd.Parameters.Add(new SqlParameter("@StreetNo", SqlDbType.NVarChar, 25)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false
            });
            cmd.Parameters.Add(new SqlParameter("@Sangkat", SqlDbType.NVarChar, 50)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false
            });
            cmd.Parameters.Add(new SqlParameter("@Khan", SqlDbType.NVarChar, 50)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false
            });
            cmd.Parameters.Add(new SqlParameter("@ProvinceOrCity", SqlDbType.NVarChar, 50)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false
            });
            cmd.Parameters.Add(new SqlParameter("@ContactNumber", SqlDbType.VarChar, 20)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false
            });
            cmd.Parameters.Add(new SqlParameter("@Photo", SqlDbType.VarBinary, int.MaxValue)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false
            });

            commands.Add(INSERT_CUSTOMER, cmd);
        }
        #endregion

        #region Generate Get All Customers Command
        private static void CreateGetAllCustomersCommand()
        {
            var cmd = new SqlCommand($"SELECT * FROM {GET_ALL_CUSTOMERS}", Connection);
            cmd.CommandType = CommandType.Text;
            commands.Add(GET_ALL_CUSTOMERS, cmd);
        }
        #endregion

        #region Generate Commands
        public static void GenerateCommands()
        {
            CreateInsertCustomerCommand();
            CreateGetAllCustomersCommand();
        }
        #endregion

        #region Add New Customer
        //public static void AddCustomer(SqlConnection conn, Customer customer)
        //{
        //    SqlCommand cmd = commands[INSERT_CUSTOMER];
        //    cmd.Parameters["@CustomerFirstName"].Value = customer.CustomerFirstName;
        //    cmd.Parameters["@CustomerLastName"].Value = customer.CustomerLastName;
        //    cmd.Parameters["@Sex"].Value = customer.Sex;
        //    cmd.Parameters["@BirthDate"].Value = customer.BirthDate;
        //    cmd.Parameters["@IdentityCardNumber"].Value = customer.IdentityCardNumber;
        //    cmd.Parameters["@HouseNo"].Value = customer.HouseNo;
        //    cmd.Parameters["@StreetNo"].Value = customer.StreetNo;
        //    cmd.Parameters["@Sangkat"].Value = customer.Sangkat;
        //    cmd.Parameters["@Khan"].Value = customer.Khan;
        //    cmd.Parameters["@ProvinceOrCity"].Value = customer.ProvinceOrCity;
        //    cmd.Parameters["@ContactNumber"].Value = customer.ContactNumber;
        //    cmd.Parameters["@Photo"].Value = customer.Photo;

        //    try
        //    {
        //        int effected = cmd.ExecuteNonQuery();
        //        if (effected > 0) Added?.Invoke(null, EventArgs.Empty);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception($"Failed in adding new customer > {ex.Message}");
        //    }
        //    finally
        //    {
        //        cmd.Dispose();
        //    }
        //}
        //#endregion

        //#region Get All Customers
        //public static IEnumerable<Customer> GetAllCustomers(SqlConnection conn)
        //{
        //    SqlCommand cmd = commands[GET_ALL_CUSTOMERS];
        //    SqlDataReader? reader = null;
        //    try
        //    {
        //        reader = cmd.ExecuteReader();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception($"Error in getting all customers > {ex.Message}");
        //    }
        //    finally
        //    {
        //        cmd.Dispose();
        //    }

        //    if (reader != null && reader.HasRows == true)
        //    {
        //        var queryable = reader.Cast<IDataRecord>().AsQueryable();
        //        foreach (var record in queryable)
        //        {
        //            yield return record.ToCustomer();
        //        }
        //    }
        //    reader?.Close();
        //}
        #endregion
    }
}
