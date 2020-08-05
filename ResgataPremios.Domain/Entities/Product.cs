using System;
using System.Text;

namespace ResgataPremios.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Point { get; set; }
        public int CategoryId { get; set; }
        public virtual ProductCategory Category { get; set; }
    }
}
