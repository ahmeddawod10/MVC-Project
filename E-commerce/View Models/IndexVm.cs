﻿using E_commerce.Models;

namespace E_commerce.View_Models
{
    public class IndexVm
    {
        public IndexVm()
        {
            Categories=new List<Category>();
            Products=new List<Product>();
            Reviews=new List<Review>();
        }
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        public List<Review> Reviews { get; set; }
    }
}
