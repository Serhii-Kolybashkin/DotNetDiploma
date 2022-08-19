using System.Collections.Generic;

namespace BusinessLogic.Entities
{
    public class ProductAssembly
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public List<PartComponent> componentsList { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
