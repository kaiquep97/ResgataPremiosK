using System;
using System.Collections.Generic;
using System.Text;

namespace ResgataPremios.Repository.Interfaces
{
    public interface IQuery<T>
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
}
