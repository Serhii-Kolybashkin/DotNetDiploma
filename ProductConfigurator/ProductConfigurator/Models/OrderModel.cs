using BusinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductConfigurator.Models
{
    public class OrderModel
    {
        public int OrderNumber { get; set; }
        public List<PartComponent> Components { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
