using System;
using System.Collections.Generic;

namespace Lab20CoffeeShopDatabase.Models
{
    public partial class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}
