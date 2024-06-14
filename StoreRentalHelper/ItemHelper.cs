using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreRentalHelper
{
    public class ItemHelper
    {
        #region Connection
        public static SqlConnection Connection { get; set; } = default!;

        #endregion

        #region Procedure and View Names
        private const string INSERT = "sp_InsertNewItem";
        private const string UPDATE = "sp_UpdateItem";
        private const string GET_ALL = "v_GetAllItems";
        #endregion

        #region Generate Insert Item Command
        public static SqlCommand CreateInsertItemCommand()
        {
            var cmd = new SqlCommand(INSERT, Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@ItemDescription ", SqlDbType.NVarChar, 255)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "ItemDescription"
            });
            cmd.Parameters.Add(new SqlParameter("@Category ", SqlDbType.NVarChar, 255)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "Category"
            });
            cmd.Parameters.Add(new SqlParameter("@Unit", SqlDbType.NVarChar, 100)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "Unit"
            });
            cmd.Parameters.Add(new SqlParameter("@UnitPrice", SqlDbType.Money)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "UnitPrice"
            });
            cmd.Parameters.Add(new SqlParameter("@StockQty", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "StockQty"
            });

            return cmd;
        }
        #endregion

        #region Generate Get All Items Command
        public static SqlCommand CreateGetAllItemsCommand()
        {
            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = $"SELECT * FROM {GET_ALL}";
            return cmd;
        }
        #endregion

        #region Generate Update Item Command
        public static SqlCommand CreateUpdateItemCommand()
        {
            var cmd = new SqlCommand(UPDATE, Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ItemID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Original,
                SourceColumn = "ItemID"
            });
            cmd.Parameters.Add(new SqlParameter("@ItemDescription ", SqlDbType.NVarChar, 255)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "ItemDescription"
            });
            cmd.Parameters.Add(new SqlParameter("@Category ", SqlDbType.NVarChar, 255)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "Category"
            });
            cmd.Parameters.Add(new SqlParameter("@Unit", SqlDbType.NVarChar, 100)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "Unit"
            });
            cmd.Parameters.Add(new SqlParameter("@UnitPrice", SqlDbType.Money)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "UnitPrice"
            });
            cmd.Parameters.Add(new SqlParameter("@StockQty", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "StockQty"
            });

            return cmd;
        }
        #endregion
    }
}
