using System.Collections.Generic;

namespace ResgataPremios.Domain.Entities
{
    public class ProductCategory
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
