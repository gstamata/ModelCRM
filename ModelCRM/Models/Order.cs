using System;
using System.Collections.Generic;
using System.Text;

namespace ModelCRM.Models
{
    public class Order
    {
        public int Id { get; set; }
        public Customer customer { get; set; }
        public string DeliveryAddress { get; set; }
        public decimal TotalAmount { get; set; }
        public List<OrderProduct> OrderPoducts { get; set; }

    }
}
