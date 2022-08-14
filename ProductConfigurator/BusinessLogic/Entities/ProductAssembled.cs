using System.Collections.Generic;

namespace BusinessLogic.Entities
{
    public class ProductAssembled
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public List<PartComponent> componentsList;
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
