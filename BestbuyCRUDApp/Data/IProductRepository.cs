using System;
using BestbuyCRUDApp.Models;

namespace BestbuyCRUDApp
{

    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProduct(int id);
    }
}

