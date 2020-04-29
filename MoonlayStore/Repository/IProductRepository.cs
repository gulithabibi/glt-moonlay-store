using MoonlayStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoonlayStore.Repository
{
    public interface IProductRepository
    {
        Task<List<Product>> getProducts();

        Task<Product> getProductById(string id);
        Task<List<Product>> getProductSearch(string str);
    }
}
