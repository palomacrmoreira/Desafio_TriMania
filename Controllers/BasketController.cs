using System.Collections.Generic;
using Desafio_TriMania.Interfaces;
using Desafio_TriMania.Models;
using Microsoft.AspNetCore.Mvc;

namespace Desafio_TriMania.Controllers
{
    [ApiController]
    [Route("baskets")]
    public class BasketController : ControllerBase
    {


        public readonly IBasketServices _basketServices;
        public BasketController(IBasketServices services)
        {
            _basketServices = services;
        }

        [HttpGet]

        public List<Basket> GetBaskets()
        {
            return _basketServices.GetBaskets();
        }

        [HttpGet("{id}")]

        public Basket GetBasket(int id)
        {
            return _basketServices.GetBasket(id);
        }

        [HttpPut]
        public Product AddItem([FromBody] Product product)
        {
            _basketServices.AddItem(product);
            return product;
        }



    }
}