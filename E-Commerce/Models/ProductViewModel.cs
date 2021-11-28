using System;
namespace E_Commerce.Models
{
    public class ProductViewModel
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public byte[] Image { get; set; }
        public string Size { get; set; }
        public int Price { get; set; }
        public int InStock { get; set; }
    }
}

