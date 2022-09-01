using BusinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductConfigurator.Models
{
    public class ViewModel
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public int PartComponentId { get; set; }
        //public virtual ICollection<PartProductJoin> PartComponents { get; set; }
    }
}
