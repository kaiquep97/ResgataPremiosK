using System;
using System.Collections.Generic;
using System.Text;

namespace ResgataPremios.Service.Interfaces
{
    public interface ILoginService
    {
        void Login(string email, string password);

    }
}
