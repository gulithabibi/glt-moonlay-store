using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoonlayStore.Models
{
    public class Prices
    {
        [Display(Name = "Price")]
        public decimal current_price { get; set; }
        public decimal previous_price { get; set; }
        public decimal checkout_discount { get; set; }
        public decimal lowest_price { get; set; }
        public string currency { get; set; }
    }
}
