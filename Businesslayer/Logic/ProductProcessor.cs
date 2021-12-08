using Businesslayer.Models;
using Datalayer.DataAccess;

namespace Businesslayer.Logic
{
    public class ProductProcessor
    {
        public static List<ProductModel> LoadProducts()
        {
            string sql = @"select * from dbo.Products;";

            return SqlDataAccess.LoadData<ProductModel>(sql);
        }
    }
}
