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
        public static event EventHandler<FormEventArgs>? Added;
        public static event EventHandler<FormEventArgs>? Updated;
        public static event EventHandler<FormEventArgs>? Deleted;
        #endregion

        #region tblStaff
        private const string STAFF_TBL_NAME = "tblStaff";
        private const string STAFF_ID_FIELD = "StaffID";
        private const string STAFF_FNAME_FIELD = "StaffFirstName";
        private const string STAFF_LNAME_FIELD = "StaffLastName";
        private const string STAFF_SEX_FIELD = "Sex";
        private const string STAFF_BIRTHDATE_FIELD = "BirthDate";
        private const string STAFF_IDENTITY_CARD_NUMBER_FIELD = "IdentityCardNumber";
        private const string STAFF_POSITION_FIELD = "StaffPosition";
        private const string STAFF_HOUSENO_FIELD = "HouseNo";
        private const string STAFF_STREETNO_FIELD = "StreetNo";
        private const string STAFF_SANGKAT_FIELD = "Sangkat";
        private const string STAFF_KHAN_FIELD = "Khan";
        private const string STAFF_PROVINCE_OR_CITY_FIELD = "ProvinceOrCity";
        private const string STAFF_CONTACT_NUMBER_FIELD = "ContactNumber";
        private const string STAFF_PERSONAL_NUMBER_FIELD = "PersonalNumber";
        private const string STAFF_SALARY_FIELD = "PersonalNumber";
        private const string STAFF_HIRED_DATE_FIELD = "PersonalNumber";
        private const string STAFF_PHOTO_FIELD = "PersonalNumber";
        private const string STAFF_STOPPED_WORK_FIELD = "PersonalNumber";
        private const string STAFF_READ_SCRIPT = $"select {STAFF_ID_FIELD},{STAFF_FNAME_FIELD},{STAFF_LNAME_FIELD} from {STAFF_TBL_NAME}";
        private static string STAFF_READ_BY_ID_SCRIPT = $"select top 1 {STAFF_ID_FIELD},{STAFF_FNAME_FIELD},{STAFF_LNAME_FIELD},{STAFF_SEX_FIELD},{STAFF_BIRTHDATE_FIELD} from {STAFF_TBL_NAME} where {STAFF_ID_FIELD}={{0}}";
        private static string STAFF_CREATE_SCRIPT = $"insert into {STAFF_TBL_NAME} values({{0}}, {{1}}, {{2}}, {{3}}, {{4}}, {{5}}, {{6}}, {{7}}, {{8}}, {{9}}, {{10}}, {{11}}, {{12}}, {{13}}, {{14}}, {{15}}, {{15}}, {{16}})";
        private static string STAFF_UPDATE_SCRIPT = $"update {STAFF_TBL_NAME} set {STAFF_FNAME_FIELD}={{1}}, {STAFF_LNAME_FIELD}={{2}}, {STAFF_SEX_FIELD}={{3}}, {STAFF_BIRTHDATE_FIELD}={{4}}, {STAFF_IDENTITY_CARD_NUMBER_FIELD}={{5}}, {STAFF_POSITION_FIELD}={{6}}, {STAFF_HOUSENO_FIELD}={{7}}, {STAFF_STREETNO_FIELD}={{8}}, {STAFF_SANGKAT_FIELD}={{9}}, {STAFF_KHAN_FIELD}={{10}}, {STAFF_PROVINCE_OR_CITY_FIELD}={{11}}, {STAFF_CONTACT_NUMBER_FIELD}={{12}}, {STAFF_PERSONAL_NUMBER_FIELD}={{13}}, {STAFF_SALARY_FIELD}={{14}}, {STAFF_HIRED_DATE_FIELD}={{15}}, {STAFF_PHOTO_FIELD}={{16}},{STAFF_STOPPED_WORK_FIELD}={{17}} where {STAFF_ID_FIELD}={{0}}";
        private static string STU_DELETE_ONE_SCRIPT = $"delete {STAFF_TBL_NAME} where {STAFF_ID_FIELD}={{0}}";
        private static string STU_DELETE_MANY_SCRIPT = $"delete {STAFF_TBL_NAME} where {STAFF_ID_FIELD} in ({{0}})";
        //Read all students
        public static IEnumerable<Staff> GetAllStaffs(SqlConnection conn)
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = STAFF_READ_SCRIPT;
            cmd.CommandType = CommandType.Text;

            SqlDataReader? reader = null;
            try
            {
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in getting all staffs > {ex.Message}");
            }

            if (reader != null && reader.HasRows == true)
            {
                while (reader.Read())
                {
                    var id = reader.GetInt32(STAFF_ID_FIELD);
                    string? firstname = null;
                    if (!reader.IsDBNull(STAFF_FNAME_FIELD)) firstname = reader.GetString(STAFF_FNAME_FIELD);
                    string? lastname = null;
                    if (!reader.IsDBNull(STAFF_LNAME_FIELD)) lastname = reader.GetString(STAFF_LNAME_FIELD);
                    yield return new Staff()
                    {
                        StaffID = id,
                        StaffFirstName = firstname!,
                        StaffLastName = lastname!
                    };
                }
            }
            reader?.Close();
        }

        ////Read a specified student
        //public static Student? GetStudentById(SqlConnection conn, string id)
        //{
        //    SqlCommand cmd = conn.CreateCommand();
        //    cmd.CommandText = string.Format(STU_READ_BY_ID_SCRIPT, $"'{id}'");
        //    cmd.CommandType = CommandType.Text;

        //    SqlDataReader? reader = null;
        //    try
        //    {
        //        reader = cmd.ExecuteReader();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception($"Error in getting student with id, {id} > {ex.Message}");
        //    }
        //    Student? result = null;
        //    if (reader != null && reader.HasRows == true)
        //    {
        //        if (reader.Read() == true)
        //        {
        //            string? firstname = null;
        //            if (!reader.IsDBNull(STU_FNAME_FIELD)) firstname = reader.GetString(STU_FNAME_FIELD);
        //            string? lastname = null;
        //            if (!reader.IsDBNull(STU_LNAME_FIELD)) lastname = reader.GetString(STU_LNAME_FIELD);
        //            Genders? gender = null;
        //            if (!reader.IsDBNull(STU_GENDER_FIELD)) gender = (Genders?)reader.GetInt32(STU_GENDER_FIELD);
        //            byte? age = null;
        //            if (!reader.IsDBNull(STU_AGE_FIELD)) age = reader.GetByte(STU_AGE_FIELD);
        //            result = new Student()
        //            {
        //                Id = id,
        //                FirstName = firstname,
        //                LastName = lastname,
        //                Gender = gender,
        //                Age = age
        //            };
        //        }
        //    }
        //    reader?.Close();
        //    return result;
        //}

        ////Create a new student
        //public static string? AddStudent(SqlConnection conn, Student student)
        //{
        //    dynamic id = $"'{student.Id}'";
        //    dynamic fname = (student.FirstName == null) ? "NULL" : $"'{student.FirstName}'";
        //    dynamic lname = (student.LastName == null) ? "NULL" : $"'{student.LastName}'";
        //    dynamic gender = (student.Gender == null) ? "NULL" : (int)student.Gender;
        //    dynamic age = (student.Age == null) ? "NULL" : student.Age;

        //    SqlCommand cmd = conn.CreateCommand();
        //    cmd.CommandText = string.Format(STU_CREATE_SCRIPT, id, fname, lname, gender, age);
        //    cmd.CommandType = CommandType.Text;
        //    try
        //    {
        //        int effected = cmd.ExecuteNonQuery();
        //        if (effected > 0)
        //            Added?.Invoke(null, new EntityEventArgs() { Id = student.Id, Entity = EntityTypes.Students });
        //        return (effected > 0) ? student.Id : null;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception($"Failed in adding new student > {ex.Message}");
        //    }
        //    finally
        //    {
        //        cmd.Dispose();
        //    }
        //}

        ////Update an existing student
        //public static bool UpdateStudent(SqlConnection conn, Student student)
        //{
        //    dynamic id = $"'{student.Id}'";
        //    dynamic fname = (student.FirstName == null) ? "NULL" : $"'{student.FirstName}'";
        //    dynamic lname = (student.LastName == null) ? "NULL" : $"'{student.LastName}'";
        //    dynamic gender = (student.Gender == null) ? "NULL" : (int)student.Gender;
        //    dynamic age = (student.Age == null) ? "NULL" : student.Age;

        //    SqlCommand cmd = conn.CreateCommand();
        //    cmd.CommandText = string.Format(STU_UPDATE_SCRIPT, id, fname, lname, gender, age);
        //    cmd.CommandType = CommandType.Text;
        //    try
        //    {
        //        int effected = cmd.ExecuteNonQuery();
        //        if (effected > 0)
        //            Updated?.Invoke(null, new EntityEventArgs() { Id = student.Id, Entity = EntityTypes.Students });
        //        return (effected > 0);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception($"Failed in updating existing student with the id {student.Id} > {ex.Message}");
        //    }
        //}

        ////Delete an existing student
        //public static bool DeleteStudent(SqlConnection conn, string id)
        //{
        //    SqlCommand cmd = conn.CreateCommand();
        //    cmd.CommandText = string.Format(STU_DELETE_ONE_SCRIPT, $"'{id}'");
        //    cmd.CommandType = CommandType.Text;
        //    try
        //    {
        //        int effected = cmd.ExecuteNonQuery();
        //        if (effected > 0)
        //            Deleted?.Invoke(null, new EntityEventArgs() { Id = id, Entity = EntityTypes.Students });
        //        return (effected > 0);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception($"Failed in deleting a student with id {id} > {ex.Message}");
        //    }
        //}

        ////Delete several existing students
        //public static int DeleteStudents(SqlConnection conn, IEnumerable<string> ids)
        //{
        //    if (ids.Count() == 0) return 0;
        //    var idSet = ids.Distinct().Select(x => $"'{x}'").ToList().Aggregate((a, b) => a + ", " + b);
        //    SqlCommand cmd = conn.CreateCommand();
        //    cmd.CommandText = string.Format(STU_DELETE_MANY_SCRIPT, idSet);
        //    cmd.CommandType = CommandType.Text;
        //    try
        //    {
        //        int effected = cmd.ExecuteNonQuery();
        //        if (effected > 0)
        //            Deleted?.Invoke(null, new EntityEventArgs() { Id = idSet, Entity = EntityTypes.Students });
        //        return effected;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception($"Failed in deleting existing students > {ex.Message}");
        //    }
        //}
        #endregion
    }
}
