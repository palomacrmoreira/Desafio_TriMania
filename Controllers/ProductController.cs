using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Desafio_TriMania.Data;
using Desafio_TriMania.Models;
using Desafio_TriMania.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Desafio_TriMania.Controllers
{

    [ApiController]
    [Route("products")]
    public class ProductController : ControllerBase
    {
        public readonly IProductServices _productServices;

        public ProductController(IProductServices services)
        {
            _productServices = services;
        }

        [HttpGet]
        public List<Product> GetProducts()
        {
            return _productServices.GetProducts();
        }

        [HttpGet("{id}")]
        public Product GetProduct(int id)
        {
            return _productServices.GetProduct(id);
        }

        [HttpPost]
        public Product CreateProduct([FromBody] Product product)
        {
            _productServices.CreateProduct(product);
            return product;
        }

        [HttpPut]
        public Product UpdatePrice([FromBody] Product product)
        {
            _productServices.UpdatePrice(product);
            return product;
        }


        [HttpDelete("{id}")]
        public int DeleteProduct(int id)
        {
            _productServices.DeleteProduct(id);
            return id;

        }

    }
}