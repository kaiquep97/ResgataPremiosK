using System;
using System.Collections.Generic;
using System.Text;

namespace ResgataPremios.Domain.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public int OrderStatusId { get; set; }
        public virtual OrderStatus Status { get; set; }
    }
}