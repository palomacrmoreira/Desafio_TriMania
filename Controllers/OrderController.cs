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
    [Route("orders")]
    public class OrderController : ControllerBase
    {
        public readonly IOrderServices _orderServices;

        public OrderController(IOrderServices services)
        {
            _orderServices = services;
        }

        [HttpGet]
        public List<Order> GetOrders()
        {
            return _orderServices.GetOrders();
        }

        [HttpGet("{id}")]
        public Order GetOrder(int id)
        {
            return _orderServices.GetOrder(id);
        }

        [HttpPost]
        public Order CreateOrder([FromBody] Order order)
        {
            _orderServices.CreateOrder(order);
            return order;
        }

        // [HttpPut]
        // public Order UpdateOrder([FromBody] Order order)
        // {
        //     _orderServices.UpdateOrder(order);
        //     return order;
        // }


        [HttpDelete("{id}")]
        public int CancelOrder(int id)
        {

            _orderServices.CancelOrder(id);
            return id;

        }

    }
}