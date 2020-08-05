using System;
using System.Collections.Generic;
using System.Text;

namespace ResgataPremios.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Document { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual ICollection<UserPoint> UserPoints { get; set; }
    }
}
