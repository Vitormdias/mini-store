using System;
using ProductService.Domain.Entities;

namespace ProductService.API.Controllers.Responses
{
    public class ProductResponse
    {
        public string Name { get; set; }
        public Guid Id { get; set; }

        public static ProductResponse From(Product product)
        {
            return new ProductResponse
            {
                Name = product.Name,
                Id = product.Id
            };
        }
    }
}
