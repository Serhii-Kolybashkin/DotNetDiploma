using BusinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductConfigurator.Models
{
    public class ProductAssemblyModel
    {
        public string Name { get; set; }

        public List<PartComponent> componentsList { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
