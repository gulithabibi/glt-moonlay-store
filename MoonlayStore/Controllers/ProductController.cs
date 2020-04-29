using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MoonlayStore.Helper;
using MoonlayStore.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using MoonlayStore.Repository;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace MoonlayStore.Controllers
{
    public class ProductController : Controller
    {
        AmazonApiHelper _amazonApi = new AmazonApiHelper();
        private IProductRepository _productRespository;

        public ProductController(IProductRepository productRepository)
        {
            _productRespository = productRepository;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        public IActionResult List(string str=null)
        {
            try
            {
                List<Product> products = new List<Product>();
                var taskRs = _productRespository.getProducts();

                products = taskRs.Result;

                foreach (var x in products)
                {
                    x.title = x.title.Substring(0, 20) + "...";
                    if (x.description.Length > 100)
                    {
                        x.description = x.description.Substring(0, 100) + "...";
                    }
                }

                return View(products);
            }
            catch(Exception ex)
            {
                return View("ErrorSTU");
            }
            
        }

        public IActionResult Search(string str = null)
        {
            try
            {
                List<Product> products = new List<Product>();
                var taskRs = _productRespository.getProductSearch(str);

                products = taskRs.Result;

                foreach (var x in products)
                {
                    x.title = x.title.Substring(0, 20) + "...";
                    if (x.description.Length > 100)
                    {
                        x.description = x.description.Substring(0, 100) + "...";
                    }
                }

                return View("List", products);
            }
            catch (Exception ex)
            {
                return View("ErrorSTU");
            }
        }

        public IActionResult Detail(string id)
        {
            Product product = new Product();

            var taskRs = _productRespository.getProductById(id);

            if (taskRs.Result != null)
            {
                product = taskRs.Result;
            }

            return View(product);
        }
    }
}