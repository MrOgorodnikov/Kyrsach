using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrsach.Model
{
    public class ProductType
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public bool IsFood { get; set; }
        
        public ICollection<Product> Product { get; set; }
        

        public ProductType()
        {
            Product = new List<Product>();
        }
    }
}
