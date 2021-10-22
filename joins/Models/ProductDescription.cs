using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace joins.Models
{
    public class ProductDescription
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductDesId { get; set; }
        public int ProductId { get; set; }
        public string ProdDetails { get; set; }
        
    }
}