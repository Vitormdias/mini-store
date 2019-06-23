using ProductService.Domain.Entities;

namespace ProductService.API.Controllers.Requests
{
    public class ProductRequest
    {
        public string Name { get; set; }

        public Product ToEntity()
        {
            return new Product
            {
                Name = this.Name
            };
        }
    }
}
