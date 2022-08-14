using System.Collections.Generic;

namespace BusinessLogic.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int OrderNumber { get; set; }
        public List<PartComponent> Components { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
