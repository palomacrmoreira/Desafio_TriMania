using Desafio_TriMania.Data;
using Desafio_TriMania.Interfaces;
using Desafio_TriMania.Models;
using System.Collections.Generic;
using System.Linq;

namespace Desafio_TriMania.Services
{
    public class BasketServices : IBasketServices
    {
        private readonly ApplicationContext _applicationContext;

        public BasketServices(ApplicationContext context)
        {
            _applicationContext = context;
            _applicationContext.Database.EnsureCreated();
        }

        public Basket GetBasket(int id)
        {
            return _applicationContext.Baskets.Find(id);
        }

        public List<Basket> GetBaskets()
        {
            return _applicationContext.Baskets.ToList();
        }

        public List<Product> PrepareToOrder()
        {
            throw new System.NotImplementedException();
        }

        public Product RemoveItem(int PoductId)
        {
            throw new System.NotImplementedException();
        }


        public Product AddItem(Product product)
        {
            Item _item = new Item();
            var _product = _applicationContext.Products.Find(product.ProductId);
            var _basket = _applicationContext.Baskets.Find(1);
            _item.Name = _product.Name;
            _item.Price = _product.Price;
            _item.Quantity = 1;
            _basket.TotalValue = 0;
            _basket.Items.Add(_item);
            int count = _basket.Items.Count();
            for (int i = 0; i < count; i++)//determinando valor total
            {
                _basket.TotalValue += _basket.Items[i].Price;
            }
            _applicationContext.Baskets.Update(_basket);
            return product;
        }
    }
}