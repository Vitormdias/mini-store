using System;
namespace ProductService.Domain.Entities
{
    public class Product
    {
        public Product ()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
