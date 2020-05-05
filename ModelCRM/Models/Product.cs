using System;
using System.Collections.Generic;
using System.Text;

namespace ModelCRM.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public List<OrderProduct> OrderProducts { get; set; }

    }
}
