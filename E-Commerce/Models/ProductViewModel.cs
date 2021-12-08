﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Drawing;

namespace E_Commerce.Models
{
    public class ProductViewModel
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public byte[] Images { get; set; }
        public int Size { get; set; }
        public int Price { get; set; }
        public int InStock { get; set; }
    }
}

