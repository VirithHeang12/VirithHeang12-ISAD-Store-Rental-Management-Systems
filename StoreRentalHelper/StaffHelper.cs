using Microsoft.Data.SqlClient;
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
        #region events
        public static event EventHandler? Added;
        public static event EventHandler? Updated;
        public static event EventHandler? Deleted;
        #endregion

        #region
        public static SqlConnection? Connection { get; set; }
        #endregion

        #region Procedure Names
        private const string INSERT_STAFF = "InsertNewStaff";
        private const string UPDATE_STAFF = "UpdateStaff";
        private const string DELETE_STAFF = "DeleteStaff";
        private const string GET_ALL_STAFFS = "GetAllStaffs";
        #endregion

        #region Commands
        private static Dictionary<string, SqlCommand> commands = new();
        #endregion

        #region Generate Insert Staff Command
        private static void CreateInsertStaffCommand()
        {
            var cmd = new SqlCommand(INSERT_STAFF, Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@StaffFirstName", SqlDbType.NVarChar, 50)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false
            });
            cmd.Parameters.Add(new SqlParameter("@StaffLastName", SqlDbType.NVarChar, 50)
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
            cmd.Parameters.Add(new SqlParameter("@IdentityCardNumber", SqlDbType.NVarChar, 10)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false
            });
            cmd.Parameters.Add(new SqlParameter("@StaffPosition", SqlDbType.NVarChar, 100)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false
            });
            cmd.Parameters.Add(new SqlParameter("@HouseNo", SqlDbType.NVarChar, 15)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false
            });
            cmd.Parameters.Add(new SqlParameter("@StreetNo", SqlDbType.NVarChar, 15)
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
            cmd.Parameters.Add(new SqlParameter("@ContactNumber", SqlDbType.NVarChar, 20)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false
            });
            cmd.Parameters.Add(new SqlParameter("@PersonalNumber", SqlDbType.NVarChar, 20)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false
            });
            cmd.Parameters.Add(new SqlParameter("@Salary", SqlDbType.Money)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false
            });
            cmd.Parameters.Add(new SqlParameter("@HiredDate", SqlDbType.Date)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false
            });
            cmd.Parameters.Add(new SqlParameter("@Photo", SqlDbType.VarBinary, int.MaxValue)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false
            });
            cmd.Parameters.Add(new SqlParameter("@StoppedWork", SqlDbType.Bit)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false
            });

            commands.Add(INSERT_STAFF, cmd);
        }
        #endregion

        #region Generate Commands
        public static void GenerateCommands()
        {
            CreateInsertStaffCommand();
        }
        #endregion

        #region
        public static void AddStaff(SqlConnection conn, Staff staff)
        {
            SqlCommand cmd = commands[INSERT_STAFF];
            cmd.Parameters["@StaffFirstName"].Value = staff.StaffFirstName;
            cmd.Parameters["@StaffLastName"].Value = staff.StaffLastName;
            cmd.Parameters["@Sex"].Value = staff.Sex;
            cmd.Parameters["@BirthDate"].Value = staff.BirthDate;
            cmd.Parameters["@IdentityCardNumber"].Value = staff.IdentityCardNumber;
            cmd.Parameters["@StaffPosition"].Value = staff.StaffPosition;
            cmd.Parameters["@HouseNo"].Value = staff.HouseNo;
            cmd.Parameters["@StreetNo"].Value = staff.StreetNo;
            cmd.Parameters["@Sangkat"].Value = staff.Sangkat;
            cmd.Parameters["@Khan"].Value = staff.Khan;
            cmd.Parameters["@ProvinceOrCity"].Value = staff.ProvinceOrCity;
            cmd.Parameters["@PersonalNumber"].Value = staff.PersonalNumber;
            cmd.Parameters["@ContactNumber"].Value = staff.ContactNumber;
            cmd.Parameters["@Salary"].Value = staff.Salary;
            cmd.Parameters["@HiredDate"].Value = staff.HiredDate;
            cmd.Parameters["@Photo"].Value = staff.Photo;
            cmd.Parameters["@StoppedWork"].Value = staff.StoppedWork;

            try
            {
                int effected = cmd.ExecuteNonQuery();
                if (effected > 0) Added?.Invoke(null, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed in adding new staff > {ex.Message}");
            }
            finally
            {
                cmd.Dispose();
            }
        }
        #endregion


    }
}
