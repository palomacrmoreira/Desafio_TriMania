using System.Collections.Generic;
using Desafio_TriMania.Interfaces;
using Desafio_TriMania.Models;
using Desafio_TriMania.Data;
using System.Linq;

namespace Desafio_TriMania.Services
{
    public class ProductServices : IProductServices
    {
        public readonly ApplicationContext _applicationContext;
        public ProductServices(ApplicationContext context)
        {
            _applicationContext = context;
            _applicationContext.Database.EnsureCreated();

        }
        public Product CreateProduct(Product product)
        {
            _applicationContext.Products.Add(product);
            _applicationContext.SaveChanges();
            return product;
        }

        public int DeleteProduct(int id)
        {
            var DeletedUser = _applicationContext.Products.Where(c => c.ProductId == id);
            _applicationContext.Products.Remove(new Product { ProductId = id });
            return id;
        }

        public Product GetProduct(int id)
        {
            return _applicationContext.Products.Find(id);
        }

        public List<Product> GetProducts()
        {
            return _applicationContext.Products.ToList();
        }

        public Product UpdatePrice(Product product)
        {
            var NewProduct = _applicationContext.Products.Find(product.ProductId);
            NewProduct.Price = product.Price;
            _applicationContext.Products.Update(NewProduct);
            _applicationContext.SaveChanges();
            return product;

        }

        public Product UpdateAvailabeQuantity(Product product)
        {
            var NewProduct = _applicationContext.Products.Find(product.ProductId);
            //inserir regras
            //NewProduct.AvailableQuantity =- product.ChosenQuantity;
            _applicationContext.Products.Update(NewProduct);
            _applicationContext.SaveChanges();
            return product;
        }
    }
}