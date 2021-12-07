using Businesslayer.Models;
using Datalayer.DataAccess;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Security.Cryptography;
using System.Web.Helpers;

namespace Businesslayer.Logic
{
    public static class CustomerProcessor
    {
        public static int CreateCustomer(string emailAddress, string password, string firstName, string lastName, DateTime birth, string country, string gender)
        {
            var hashedPassword = Crypto.HashPassword(password);

            CustomerModel data = new CustomerModel
            {
                EmailAddress = emailAddress,
                PasswordHash = hashedPassword,
                FirstName = firstName,
                LastName = lastName,
                Birth = birth,
                Country = country,
                Gender = gender,
            };

            string sql = @"insert into dbo.Customer (EmailAddress, PasswordHash, FirstName, LastName, Birth, Country, Gender) values (@EmailAddress, @PasswordHash, @FirstName, @LastName, @Birth, @Country, @Gender);";

            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<CustomerModel> LoadCustomers()
        {
            string sql = @"select * from dbo.Customer;";

            return SqlDataAccess.LoadData<CustomerModel>(sql);
        }
    }
}
