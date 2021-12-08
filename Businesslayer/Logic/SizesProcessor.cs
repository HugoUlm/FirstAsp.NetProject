using Businesslayer.Models;
using Datalayer.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer.Logic
{
    public class SizesProcessor
    {
        public static List<SizeModel> LoadSizes()
        {
            string sql = @"select * from dbo.Sizes;";

            return SqlDataAccess.LoadData<SizeModel>(sql);
        }
    }
}
