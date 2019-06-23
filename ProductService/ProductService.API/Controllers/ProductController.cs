using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ProductService.API.Controllers.Requests;
using ProductService.Domain.Repositories;
using System.Linq;
using ProductService.API.Controllers.Responses;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductService.API.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        // GET: api/product
        [HttpGet]
        public IEnumerable<ProductResponse> Get()
        {
            return _productRepository.GetAll()
                .Select(ProductResponse.From);
        }

        // GET api/product/5
        [HttpGet("{id}")]
        public ProductResponse Get(Guid id)
        {
            return ProductResponse.From(_productRepository.Get(id));
        }

        // POST api/product
        [HttpPost]
        public void Post([FromBody]ProductRequest request)
        {
            _productRepository.Save(request.ToEntity());
        }
    }
}
