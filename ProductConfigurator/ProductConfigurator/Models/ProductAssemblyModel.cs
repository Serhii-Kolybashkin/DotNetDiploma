using BusinessLogic.Entities;
using System.Collections.Generic;

namespace ProductConfigurator.Models
{
    public class ProductAssemblyModel
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public int PartComponentId { get; set; }
    }
}
