using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BusinessLogic.Entities
{
    public class ProductAssembly
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public int PartComponentId { get; set; }
        public virtual ICollection<PartComponent> PartComponents { get; set; }
    }
}
