using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreRentalHelper
{
    public class AppointmentHelper
    {
        #region Connection
        public static SqlConnection Connection { get; set; } = default!;
        #endregion

        #region Procedure and View Names
        private const string INSERT_APPOINTMENT = "spInsertNewOrUpdateAppointment";
        private const string GET_ALL_APPOINTMENTS = "vGetAllAppointments";
        private const string GET_ALL_APPOINTMENT_DETAILS = "vGetAllAppointmentDetails";

        private const string GET_ALL_CUSTOMERS_FOR_COMBO_BOX = "vGetAllCustomersForComboBox";
        private const string GET_ALL_STAFFS_FOR_COMBO_BOX = "vGetAllStaffsForComboBox";
        #endregion

        #region Generate Insert or Update Appointment Command
        public static SqlCommand CreateInsertOrUpdateAppointmentCommand()
        {
            var cmd = new SqlCommand(INSERT_APPOINTMENT, Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@AppointmentID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "AppointmentID"
            });
            cmd.Parameters.Add(new SqlParameter("@AppointmentDate", SqlDbType.Date)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "AppointmentDate"
            });
            
            cmd.Parameters.Add(new SqlParameter("@CustomerID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "CustomerID"
            });
            cmd.Parameters.Add(new SqlParameter("@AppointmentStatus", SqlDbType.NVarChar, 100)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
                SourceVersion = DataRowVersion.Current,
                SourceColumn = "AppointmentStatus"
            });
           
            cmd.Parameters.Add(new SqlParameter("@StaffAssignments", SqlDbType.Structured)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
            });
            return cmd;
        }
        #endregion

        #region Generate Get All Appointments Command
        public static SqlCommand CreateGetAllAppointmentsCommand()
        {
            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = $"SELECT * FROM {GET_ALL_APPOINTMENTS}";
            return cmd;
        }
        #endregion

        #region Generate Get All Appointment Details Command
        public static SqlCommand CreateGetAllAppointmentDetailsCommand()
        {
            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = $"SELECT * FROM {GET_ALL_APPOINTMENT_DETAILS}";
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

        #region Generate Get All Staffs For Combo Box Command
        public static SqlCommand CreateGetAllStaffsForComboBoxCommand()
        {
            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = $"SELECT * FROM {GET_ALL_STAFFS_FOR_COMBO_BOX}";
            return cmd;
        }
        #endregion

    }
}
