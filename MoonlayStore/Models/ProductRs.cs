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
}
