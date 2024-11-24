using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicMVCProject.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}