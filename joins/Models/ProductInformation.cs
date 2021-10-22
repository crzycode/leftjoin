using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace joins.Models
{
    public class ProductInformation
    {
        public int ProId { get; set; }
        public string ProName { get; set; }
        public decimal Price { get; set; }
        public string ModelName { get; set; }
        public string ProdDetails { get; set; }
    }
}