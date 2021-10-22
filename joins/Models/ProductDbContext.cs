using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace joins.Models
{
    public class ProductDbContext: DbContext
    {
        public DbSet<Product> products { get; set; }
        public DbSet<ModelInfo> ModelInfos { get; set; }
        public DbSet<ProductDescription> ProductDescriptions { get; set; }
    }
}