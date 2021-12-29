using Desafio_TriMania.Models;
using System.Collections.Generic;

namespace Desafio_TriMania.Interfaces
{
    public interface IBasketServices
    {
           Product AddItem (Product product);
           Product RemoveItem(int PoductId);
           Basket GetBasket (int id);
           List<Basket> GetBaskets();
           List<Product> PrepareToOrder();

    }
}