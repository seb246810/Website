﻿namespace course.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ProductAlt { get; set; }

        public string ProductImage { get; set; }
    }
}
