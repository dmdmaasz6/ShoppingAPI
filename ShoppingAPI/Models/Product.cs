﻿using System;
namespace ShoppingAPI.Models
{
    public class Product
    {
        public Product()
        {

        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
    }
}
