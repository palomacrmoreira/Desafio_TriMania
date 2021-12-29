using System.Collections.Generic;
using Desafio_TriMania.Interfaces;
using Desafio_TriMania.Models;
using Desafio_TriMania.Data;
using System.Linq;
namespace Desafio_TriMania.Services
{
    public class OrderServices : IOrderServices
    {
        public readonly ApplicationContext _applicationContext;

        public OrderServices(ApplicationContext context)
        {
            _applicationContext = context;
            _applicationContext.Database.EnsureCreated();
        }
        public int CancelOrder(int id)
        {
            _applicationContext.Orders.Remove(new Order { OrderId = id });
            _applicationContext.SaveChanges();
            return id;
        }

        public Order CreateOrder(Order order)
        {
            var _order = order;
            _order.TotalValue = 0;
            int count = _order.Products.Count();
            for (int i = 0; i < count; i ++)//determinando valor total
            {
                _order.TotalValue += _order.Products[i].Price;
            }
            _applicationContext.Orders.Add(_order);//inserindo no banco de dados
            _applicationContext.SaveChanges();
            return order;
        }

        public Order GetOrder(int id)
        {
            return _applicationContext.Orders.Find(id);
        }

        public List<Order> GetOrders()
        {
            return _applicationContext.Orders.ToList();
        }
    }
}