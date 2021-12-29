using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.Sqlite;
using Desafio_TriMania.Data;
using Desafio_TriMania.Models;
using System.Collections.Generic;

namespace Desafio_TriMania.Interfaces
{
    public interface IOrderServices
    {
        List<Order> GetOrders();
        Order GetOrder(int id);
        Order CreateOrder (Order order);
        int CancelOrder (int id);
         
    }
}