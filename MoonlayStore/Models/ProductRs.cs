using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoonlayStore.Models
{
    public class ProductRs
    {
        public bool error { get; set; }
        public List<Product> offers { get; set; }
    }

    public class Product
    {
        public bool error { get; set; }
        public string asin { get; set; }

        public List<string> images { get; set; }
        [Display(Name ="Name")]
        public string title { get; set; }

        [Display(Name = "Price")]
        public Prices prices { get; set; }

        [Display(Name = "Description")]
        public string description { get; set; }
        public string category { get; set; }
        public string brand { get; set; }

        public string full_link { get; set; }

        public reviews reviews { get; set; }
    }

    public class Prices
    {
        [Display(Name = "Price")]
        public decimal current_price { get; set; }
        public decimal previous_price { get; set; }
        public decimal checkout_discount { get; set; }
        public decimal lowest_price { get; set; }
        public string currency { get; set; }
    }

    public class reviews
    {
        public string total_reviews { get; set; }
        public string stars { get; set; }
    }

}
