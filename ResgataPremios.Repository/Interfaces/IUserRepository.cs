using ResgataPremios.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResgataPremios.Repository.Interfaces
{
    public interface IUserRepository: IQuery<User>, ICommand<User>
    {
    }
}
