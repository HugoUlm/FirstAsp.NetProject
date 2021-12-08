using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
        public byte[] Images { get; set; }
        public int Size { get; set; }
        public int InStock { get; set; }
        public string ProductNo { get; set; }
    }
}
