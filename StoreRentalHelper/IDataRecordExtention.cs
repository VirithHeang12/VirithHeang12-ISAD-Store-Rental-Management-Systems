using StoreRentalLib;
using StoreRentalHelper.entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreRentalHelper
{
    public static class IDataRecordExtension
    {
        public static Staff ToStaff(this IDataRecord record)
        {
            int index = record.GetOrdinal("StaffID");
            int staffID = record.GetInt32(index);

            index = record.GetOrdinal("StaffFirstName");
            string? staffFirstName = null;
            if (!record.IsDBNull(index)) staffFirstName = record.GetString(index);

            index = record.GetOrdinal("StaffLastName");
            string? staffLastName = null;
            if (!record.IsDBNull(index)) staffLastName = record.GetString(index);

            index = record.GetOrdinal("Sex");
            char sex = default;
            if (!record.IsDBNull(index)) sex = record.GetChar(index);

            index = record.GetOrdinal("BirthDate");
            DateOnly birthDate;
            if (!record.IsDBNull(index)) birthDate = DateOnly.FromDateTime(record.GetDateTime(index));

            index = record.GetOrdinal("IdentityCardNumber");
            string? identityCardNumber = null;
            if (!record.IsDBNull(index)) identityCardNumber = record.GetString(index);

            index = record.GetOrdinal("StaffPosition");
            string? staffPosition = null;
            if (!record.IsDBNull(index)) staffPosition = record.GetString(index);

            index = record.GetOrdinal("HouseNo");
            string? houseNo = null;
            if (!record.IsDBNull(index)) houseNo = record.GetString(index);

            index = record.GetOrdinal("StreetNo");
            string? streetNo = null;
            if (!record.IsDBNull(index)) streetNo = record.GetString(index);

            index = record.GetOrdinal("Sangkat");
            string? sangkat = null;
            if (!record.IsDBNull(index)) sangkat = record.GetString(index);

            index = record.GetOrdinal("Khan");
            string? khan = null;
            if (!record.IsDBNull(index)) khan = record.GetString(index);

            index = record.GetOrdinal("ProvinceOrCity");
            string? provinceOrCity = null;
            if (!record.IsDBNull(index)) provinceOrCity = record.GetString(index);

            index = record.GetOrdinal("ContactNumber");
            string? contactNumber = null;
            if (!record.IsDBNull(index)) contactNumber = record.GetString(index);

            index = record.GetOrdinal("PersonalNumber");
            string? personalNumber = null;
            if (!record.IsDBNull(index)) personalNumber = record.GetString(index);

            index = record.GetOrdinal("Salary");
            decimal salary = default;
            if (!record.IsDBNull(index)) salary = record.GetDecimal(index);

            index = record.GetOrdinal("HiredDate");
            DateOnly hiredDate = default;
            if (!record.IsDBNull(index)) hiredDate = DateOnly.FromDateTime(record.GetDateTime(index)); ;

            index = record.GetOrdinal("Photo");
            byte[]? photo = null;
            if (!record.IsDBNull(index)) photo = (byte[]) record.GetValue(index);

            index = record.GetOrdinal("StoppedWork");
            bool stoppedWork = default;
            if (!record.IsDBNull(index)) stoppedWork = record.GetBoolean(index);

            return new Staff()
            {
                StaffID = staffID,
                StaffFirstName = staffFirstName!,
                StaffLastName = staffLastName!,
                Sex = sex,
                BirthDate = birthDate,
                IdentityCardNumber = identityCardNumber!,
                StaffPosition = staffPosition!,
                HouseNo = houseNo!,
                StreetNo = streetNo!,
                Sangkat = sangkat!,
                Khan = khan!,
                ProvinceOrCity = provinceOrCity!,
                ContactNumber = contactNumber!,
                PersonalNumber = personalNumber!,
                Salary = salary,
                HiredDate = hiredDate,
                Photo = photo!,
                StoppedWork = stoppedWork

            };
        }
    }
}
