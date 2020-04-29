using MoonlayStore.Helper;
using MoonlayStore.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MoonlayStore.Repository
{
    public class ProductRespository : IProductRepository
    {
        private AmazonApiHelper _amazonApi = new AmazonApiHelper();

        public async Task<Product> getProductById(string id)
        {

            Product product = new Product();
            HttpClient client = _amazonApi.Initial();
            HttpResponseMessage res = await client.GetAsync("product?country=US&asin="+id);

            var result = res.Content.ReadAsStringAsync().Result;

            if (res.IsSuccessStatusCode)
            {
                product = JsonConvert.DeserializeObject<Product>(result);
            }


            return product;
        }

        public async Task<List<Product>> getProducts()
        {
            ProductRs productRs = new ProductRs();
            HttpClient client = _amazonApi.Initial();
            HttpResponseMessage res =await client.GetAsync("offers?type=LIGHTNING_DEAL&max_number=100&min_number=5&country=US");

            var result = res.Content.ReadAsStringAsync().Result;

            if (res.IsSuccessStatusCode)
            {   
                productRs = JsonConvert.DeserializeObject<ProductRs>(result);
            }
            else
            {
                throw new Exception("Error when call method getProducts.");
            }
            

            return productRs.offers;
        }

        public async Task<List<Product>> getProductSearch(string str)
        {
            List<Product> products = new List<Product>();
            HttpClient client = _amazonApi.Initial();
            HttpResponseMessage res = await client.GetAsync("offers?type=LIGHTNING_DEAL&max_number=100&min_number=5&country=US");

            var result = res.Content.ReadAsStringAsync().Result;

            if (res.IsSuccessStatusCode)
            {
                ProductRs productRs = JsonConvert.DeserializeObject<ProductRs>(result);

                products = productRs.offers;

                if (products != null && products.Count > 0)
                {
                    products = products.Where(x => x.category.Contains(str) || x.title.Contains(str)).ToList();
                }
            }
            else
            {
                throw new Exception("Error when call method getProductSearch.");
            }

            return products;
        }
    }
}
