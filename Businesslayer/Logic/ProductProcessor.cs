using Businesslayer.Models;
using Datalayer.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer.Logic
{
    public class ProductProcessor
    {
        public static List<ProductModel> LoadCustomers()
        {
            string sql = @"select Id, Brand, Model, Price from dbo.Product;";

            return SqlDataAccess.LoadData<ProductModel>(sql);
        }
    }
}
