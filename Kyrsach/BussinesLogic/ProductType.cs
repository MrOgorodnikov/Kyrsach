using Kyrsach.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrsach.BussinesLogic
{
    public class ProductType
    {
        public static List<Model.ProductType> GetAllProductTypes()
        {
            using(var db = new ProductContext())
            {
                return db.ProductTypes.ToList();
            }
        }
    }
}
