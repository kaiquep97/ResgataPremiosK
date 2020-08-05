using ResgataPremios.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResgataPremios.Service.Interfaces
{
    public interface IUserService
    {
        void CreateUser(User user);
        void UpdateUser(User user);
        IEnumerable<User> GetUsers();
        IEnumerable<User> GetUserByName(string name);

    }
}
