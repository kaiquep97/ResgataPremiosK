using System;
using System.Collections.Generic;
using System.Text;

namespace ResgataPremios.Domain.Entities
{
    public class UserPoint
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public double Point { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
