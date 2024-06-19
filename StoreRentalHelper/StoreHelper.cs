using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreRentalHelper
{
    public static class StoreHelper
    {
        #region Connection
        public static SqlConnection Connection { get; set; } = default!;
        #endregion

        #region Procedure and View Names
        private const string INSERT_STORE = "sp_InsertNewStore";
        private const string UPDATE_STORE = "sp_UpdateStore";
        private const string GET_ALL_STORES = "v_GetAllStores";


        private const string GET_ALL_STORETYPES_FOR_COMBO_BOX = "v_GetAllStoreTypesForComboBox";
        #endregion

        #region Generate Insert Store Command
        public static SqlCommand CreateInsertStoreCommand()
        {
            var cmd = new SqlCommand(INSERT_STORE, Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@FloorNumber", SqlDbType.TinyInt)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "FloorNumber"
            });
            cmd.Parameters.Add(new SqlParameter("@ElectricityLastRecord", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "ElectricityLastRecord"
            });
            cmd.Parameters.Add(new SqlParameter("@WaterLastRecord", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "WaterLastRecord"
            });
            cmd.Parameters.Add(new SqlParameter("@Status", SqlDbType.Bit)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "Status"
            });
            cmd.Parameters.Add(new SqlParameter("@StoreTypeID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "StoreTypeID"
            });
            return cmd;
        }
        #endregion

        #region Generate Update Store Command
        public static SqlCommand CreateUpdateStoreCommand()
        {
            var cmd = new SqlCommand(UPDATE_STORE, Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@StoreID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Original,
                SourceColumn = "StoreID"
            });
            cmd.Parameters.Add(new SqlParameter("@FloorNumber", SqlDbType.TinyInt)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "FloorNumber"
            });
            cmd.Parameters.Add(new SqlParameter("@ElectricityLastRecord", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "ElectricityLastRecord"
            });
            cmd.Parameters.Add(new SqlParameter("@WaterLastRecord", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "WaterLastRecord"
            });
            cmd.Parameters.Add(new SqlParameter("@Status", SqlDbType.Bit)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "Status"
            });
            cmd.Parameters.Add(new SqlParameter("@StoreTypeID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "StoreTypeID"
            });
            return cmd;

        }
        #endregion

        #region Generate Get All Stores Command
        public static SqlCommand CreateGetAllStoresCommand()
        {
            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = $"SELECT * FROM {GET_ALL_STORES}";
            return cmd;
        }
        #endregion

        #region Generate Get All StoreTypes For Combo Box Command
        public static SqlCommand CreateGetAllStoreTypesForComboBoxCommand()
        {
            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = $"SELECT * FROM {GET_ALL_STORETYPES_FOR_COMBO_BOX}";
            return cmd;
        }
        #endregion

        
    }
}
