using System.Collections.Generic;

namespace BusinessLogic.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int OrderNumber { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<PartComponent> PartComponents { get; set; }
        public int PartComponentId { get; set; }
    }
}
