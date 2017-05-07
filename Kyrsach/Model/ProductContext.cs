using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrsach.Model
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }        
        public DbSet<ProductType> ProductTypes { get; set; }

        public ProductContext() : base("DbConnection")
        {
        }
    }
}
