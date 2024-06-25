using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreRentalHelper
{
    public class HomeDesignHelper
    {
        #region Connection
        public static SqlConnection Connection { get; set; } = default!;

        #endregion

        #region Count Rented Store 
        private const string COUNT_RENTED_STORES = "dbo.fnCountRentedStores";
        private const string COUNT_ALL_STORES = "dbo.fnCountAllStores";
        private const string COUNT_ALL_STAFFS = "dbo.fnCountAllStaffs";
        private const string COUNT_ALL_CUSTOMERS = "dbo.fnCountAllCustomers";
        private const string COUNT_ALL_INSURANCES = "dbo.fnCountAllInsurances";
        #endregion

        #region GetAllCountRentedStore
        public static string GetRentedStoreCount(SqlConnection connection)
        {
            using var command = new SqlCommand($"SELECT {COUNT_RENTED_STORES}()", connection);
            var dataSet = new DataSet();
            using var adapter = new SqlDataAdapter(command);
            adapter.Fill(dataSet);

            if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
            {
                return dataSet.Tables[0].Rows[0][0].ToString();
            }

            return string.Empty;
        }

        #endregion

        #region GetAllCountAllStores
        public static string GetAllStores(SqlConnection connection)
        {
            using var command = new SqlCommand($"SELECT {COUNT_ALL_STORES}()", connection);
            var dataSet = new DataSet();
            using var adapter = new SqlDataAdapter(command);
            adapter.Fill(dataSet);

            if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
            {
                return dataSet.Tables[0].Rows[0][0].ToString();
            }

            return string.Empty;
        }

        #endregion

        #region GetAllCountAllStaffs
        public static string GetAllStaffs(SqlConnection connection)
        {
            using var command = new SqlCommand($"SELECT {COUNT_ALL_STAFFS}()", connection);
            var dataSet = new DataSet();
            using var adapter = new SqlDataAdapter(command);
            adapter.Fill(dataSet);

            if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
            {
                return dataSet.Tables[0].Rows[0][0].ToString();
            }

            return string.Empty;
        }

        #endregion

        #region GetAllCountAllCustomers
        public static string GetAllCustomers(SqlConnection connection)
        {
            using var command = new SqlCommand($"SELECT {COUNT_ALL_CUSTOMERS}()", connection);
            var dataSet = new DataSet();
            using var adapter = new SqlDataAdapter(command);
            adapter.Fill(dataSet);

            if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
            {
                return dataSet.Tables[0].Rows[0][0].ToString();
            }

            return string.Empty;
        }

        #endregion

        #region GetAllCountAllInsurances
        public static string GetAllInsurances(SqlConnection connection)
        {
            using var command = new SqlCommand($"SELECT {COUNT_ALL_INSURANCES}()", connection);
            var dataSet = new DataSet();
            using var adapter = new SqlDataAdapter(command);
            adapter.Fill(dataSet);

            if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
            {
                return dataSet.Tables[0].Rows[0][0].ToString();
            }

            return string.Empty;
        }

        #endregion
    }
}
