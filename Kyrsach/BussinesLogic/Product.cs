using Kyrsach.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrsach.BussinesLogic
{
    public class Product : IAdd
    {
        private Model.Product product { get; set; }

        public Product(Model.Product food)
        {
            this.product = food;
            
        }
        public Product(string ean13)
        {
            using (var db = new ProductContext())
            {
                product = db.Products
                    .Include(p => p.ProductType)
                    .FirstOrDefault(cf => cf.EAN13 == ean13);                 
            }   
        }

        public void Add()
        {
            Add(product);
        }
        public static void Add(Model.Product product)
        {
            using (var db = new ProductContext())
            {
                db.Products.Add(product);
                db.SaveChanges();
            }
        }

        public void Delete()
        {
            Delete(product);
        }
        public static void Delete(Model.Product product)
        {
            using (var db = new ProductContext())
            {
                db.Products.Remove(product);
                db.SaveChanges();
            }
        }

        public Model.Product Read()
        {
            return product;
        }
        public static Model.Product Read(string ean13)
        {
            using (var db = new ProductContext())
            {
                return db.Products.FirstOrDefault(cf => cf.EAN13 == ean13);
            }
        }

        public void Update()
        {
            using (var db = new ProductContext())
            {
                var currentProduct = db.Products.FirstOrDefault(cf => cf.Id == product.Id);
                Update(currentProduct);
            }
        }
        public static void Update(Model.Product product)
        {
            using (var db = new ProductContext())
            {
                var currentProduct = db.Products.FirstOrDefault(cf => cf.EAN13 == product.EAN13);
                currentProduct.EAN13 = product.EAN13;
                
                currentProduct.Manufacturer = product.Manufacturer;
                currentProduct.Name = product.Name;
                currentProduct.Price = product.Price;
                currentProduct.ProductTypeId = product.ProductTypeId;
                currentProduct.ShelfLifeInDays = product.ShelfLifeInDays;
                db.SaveChanges();
            }
        }

        public Model.ProductType GetProductType() => product.ProductType;        

        public static List<string> GetAllEAN13()
        {
            using (var db = new ProductContext())
            {
                return db.Products.Select(p => p.EAN13).ToList();
            }
        }
    }
}
