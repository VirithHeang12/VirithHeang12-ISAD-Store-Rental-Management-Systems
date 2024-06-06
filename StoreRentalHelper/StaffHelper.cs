﻿using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using StoreRentalHelper.entities;
using StoreRentalLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreRentalHelper
{
    public static class StaffHelper
    {
        public static SqlConnection Connection = default!;
        #region Procedure and View Names
        private const string INSERT_STAFF = "sp_InsertNewStaff";
        private const string UPDATE_STAFF = "sp_UpdateStaff";
        private const string DELETE_STAFF = "sp_DeleteStaff";
        private const string GET_ALL_STAFFS = "v_GetAllStaffs";
        #endregion

        #region Generate Insert Staff Command
        public static SqlCommand CreateInsertStaffCommand()
        {
            var cmd = new SqlCommand(INSERT_STAFF, Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@StaffFirstName", SqlDbType.NVarChar, 50)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,      
                SourceVersion = DataRowVersion.Current,
            });
            cmd.Parameters.Add(new SqlParameter("@StaffLastName", SqlDbType.NVarChar, 50)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
            });
            cmd.Parameters.Add(new SqlParameter("@Sex", SqlDbType.Char, 1)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
            });
            cmd.Parameters.Add(new SqlParameter("@BirthDate", SqlDbType.Date)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
            });
            cmd.Parameters.Add(new SqlParameter("@IdentityCardNumber", SqlDbType.VarChar, 10)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
            });
            cmd.Parameters.Add(new SqlParameter("@StaffPosition", SqlDbType.NVarChar, 100)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
            });
            cmd.Parameters.Add(new SqlParameter("@HouseNo", SqlDbType.NVarChar, 25)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
            });
            cmd.Parameters.Add(new SqlParameter("@StreetNo", SqlDbType.NVarChar, 25)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
            });
            cmd.Parameters.Add(new SqlParameter("@Sangkat", SqlDbType.NVarChar, 50)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
            });
            cmd.Parameters.Add(new SqlParameter("@Khan", SqlDbType.NVarChar, 50)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
            });
            cmd.Parameters.Add(new SqlParameter("@ProvinceOrCity", SqlDbType.NVarChar, 50)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
            });
            cmd.Parameters.Add(new SqlParameter("@ContactNumber", SqlDbType.VarChar, 20)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
            });
            cmd.Parameters.Add(new SqlParameter("@PersonalNumber", SqlDbType.VarChar, 20)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
            });
            cmd.Parameters.Add(new SqlParameter("@Salary", SqlDbType.Money)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
            });
            cmd.Parameters.Add(new SqlParameter("@HiredDate", SqlDbType.Date)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
            });
            cmd.Parameters.Add(new SqlParameter("@Photo", SqlDbType.VarBinary, int.MaxValue)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
            });
            cmd.Parameters.Add(new SqlParameter("@StoppedWork", SqlDbType.Bit)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
            });

            return cmd;
        }
        #endregion

        #region Generate Get All Staffs Command
        public static SqlCommand CreateGetAllStaffsCommand()
        {
            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = $"SELECT * FROM {GET_ALL_STAFFS}";
            return cmd;
        }
        #endregion

        #region Generate Update Staff Command
        public static SqlCommand CreateUpdateStaffCommand()
        {
            var cmd = new SqlCommand(UPDATE_STAFF, Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@StaffFirstName", SqlDbType.NVarChar, 50)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Original,
            });
            cmd.Parameters.Add(new SqlParameter("@StaffLastName", SqlDbType.NVarChar, 50)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Original,
            });
            cmd.Parameters.Add(new SqlParameter("@Sex", SqlDbType.Char, 1)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Original,
            });
            cmd.Parameters.Add(new SqlParameter("@BirthDate", SqlDbType.Date)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Original,
            });
            cmd.Parameters.Add(new SqlParameter("@IdentityCardNumber", SqlDbType.VarChar, 10)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Original,
            });
            cmd.Parameters.Add(new SqlParameter("@StaffPosition", SqlDbType.NVarChar, 100)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Original,
            });
            cmd.Parameters.Add(new SqlParameter("@HouseNo", SqlDbType.NVarChar, 25)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Original,
            });
            cmd.Parameters.Add(new SqlParameter("@StreetNo", SqlDbType.NVarChar, 25)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Original,
            });
            cmd.Parameters.Add(new SqlParameter("@Sangkat", SqlDbType.NVarChar, 50)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Original,
            });
            cmd.Parameters.Add(new SqlParameter("@Khan", SqlDbType.NVarChar, 50)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Original,
            });
            cmd.Parameters.Add(new SqlParameter("@ProvinceOrCity", SqlDbType.NVarChar, 50)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Original,
            });
            cmd.Parameters.Add(new SqlParameter("@ContactNumber", SqlDbType.VarChar, 20)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Original,
            });
            cmd.Parameters.Add(new SqlParameter("@PersonalNumber", SqlDbType.VarChar, 20)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Original,
            });
            cmd.Parameters.Add(new SqlParameter("@Salary", SqlDbType.Money)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Original,
            });
            cmd.Parameters.Add(new SqlParameter("@HiredDate", SqlDbType.Date)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Original,
            });
            cmd.Parameters.Add(new SqlParameter("@Photo", SqlDbType.VarBinary, int.MaxValue)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Original,
            });
            cmd.Parameters.Add(new SqlParameter("@StoppedWork", SqlDbType.Bit)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Original,
            });

            return cmd;
        }
        #endregion
    }
}
