using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrsach.Model
{
    public class ProductEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EAN13 { get; set; }
        public string Manufacturer { get; set; }
        public double Price { get; set; }
        public int ShelfLifeInDays { get; set; }

        public int ProductTypeId { get; set; }
        public ProductType ProductType { get; set; }
    }
}
