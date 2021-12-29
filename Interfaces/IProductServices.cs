using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.Sqlite;
using Desafio_TriMania.Data;
using Desafio_TriMania.Models;
using System.Collections.Generic;

namespace Desafio_TriMania.Interfaces
{
    public interface IProductServices
    {   
        Product CreateProduct(Product product);
        Product GetProduct (int id);
        List<Product> GetProducts ();
        int DeleteProduct (int id);
        Product UpdatePrice (Product product);
        Product UpdateAvailabeQuantity (Product product);
         
    }
}