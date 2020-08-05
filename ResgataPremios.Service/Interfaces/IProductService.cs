using ResgataPremios.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResgataPremios.Service.Interfaces
{
    public interface IProductService
    {
        void CreateProduct(Product product);
        void UpdateProduct(Product product);
    }
}
