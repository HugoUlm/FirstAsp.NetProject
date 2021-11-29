using Datalayer.DataAccess;
using Datalayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalayer.BusinessLogic
{
    public static class CustomerProcessor
    {
        public static int CreateCustomer(string emailAddress, string firstName, string lastName, DateTime birth, string country, string gender)
        {
            CustomerModel data = new CustomerModel
            {
                EmailAddress = emailAddress,
                FirstName = firstName,
                LastName = lastName,
                Birth = birth,
                Country = country,
                Gender = gender
            };

            string sql = @"insert into dbo.Customer (EmailAddress, FirstName, LastName, Birth, Country, Gender) values (@EmailAddress, @FirstName, @LastName, @Birth, @Country, @Gender);";

            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<CustomerModel> LoadCustomers()
        {
            string sql = @"select Id, EmailAddress, FirstName, LastName, Birth, Country, Gender from dbo.Customer;";

            return SqlDataAccess.LoadData<CustomerModel>(sql);
        }
    }
}
