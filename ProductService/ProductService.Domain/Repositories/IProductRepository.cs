using System;
using System.Collections.Generic;
using ProductService.Domain.Entities;

namespace ProductService.Domain.Repositories
{
    public interface IProductRepository
    {
        void Save(Product product);
        IEnumerable<Product> GetAll();
        Product Get(Guid id);
    }
}
