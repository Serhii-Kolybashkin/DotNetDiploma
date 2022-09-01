using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLogic.Entities
{
    public class PartComponent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<ProductAssembly> ProductAssemblies { get; set; }
        public virtual Order Order { get; set; }
        public int? OrderId { get; set; }
    }
}
