using System;
using System.Collections.Generic;
using ProductService.Domain.Entities;
using ProductService.Domain.Repositories;
using System.Linq;
using ProductService.Infra.Context;

namespace ProductService.Infra.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private DataContext _dbContext { get; set; }

        public ProductRepository(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Product Get(Guid id)
        {
            return _dbContext.Products.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Product> GetAll()
        {
            return _dbContext.Products.ToList();
        }

        public void Save(Product product)
        {
            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
        }
    }
}
