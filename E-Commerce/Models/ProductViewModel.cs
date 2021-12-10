using Microsoft.AspNetCore.Mvc;
using System;
using System.Drawing;

namespace E_Commerce.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public byte[] Images { get; set; }
        public List<SizeViewModel> Sizes { get; set; }
        public int Price { get; set; }
        public int InStock { get; set; }
        public string ProductNo { get; set; }
        public string Description { get; set; }
    }
}

