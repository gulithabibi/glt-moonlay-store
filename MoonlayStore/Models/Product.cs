using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoonlayStore.Models
{
    public class Product
    {

        public bool error { get; set; }
        public string asin { get; set; }

        public List<string> images { get; set; }
        [Display(Name = "Name")]
        public string title { get; set; }

        [Display(Name = "Price")]
        public Prices prices { get; set; }

        [Display(Name = "Description")]
        public string description { get; set; }
        public string category { get; set; }
        public string brand { get; set; }

        public string full_link { get; set; }

        public Reviews reviews { get; set; }
    }
    
}
