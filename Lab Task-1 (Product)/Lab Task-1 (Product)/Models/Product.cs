using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab_Task_1__Product_.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public float Price { get; set; }

        public int Quantity { get; set; }

        public string Description { get; set; }
    }
}