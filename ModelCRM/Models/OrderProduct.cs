﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ModelCRM.Models
{
   public class OrderProduct
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public Order Order { get; set; }
    }
}
