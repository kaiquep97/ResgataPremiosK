using System;
using System.Collections.Generic;
using System.Text;

namespace ResgataPremios.Repository.Interfaces
{
    public interface ICommand<T>
    {
        void Insert(T obj);
        void Update(T obj);
        void Delete(T obj);
    }
}
