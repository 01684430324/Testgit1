using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;
namespace Model.DAO
{
   public class ProductDAO
    {
        ProductEntity db = new ProductEntity();
        public List<Product> GetAll()
        {
            return db.Products.ToList();
        }

        public int AddProduct(Product p)
        {
            db.Products.Add(p);
            db.SaveChanges();
            return p.ID;
        }

        public int DeleteProduct (int id)
        {
            Product p = db.Products.SingleOrDefault(n=>n.ID==id);
            db.Products.Remove(p);
            db.SaveChanges();
            return p.ID;
        }

        public Product GetID(int ma)
        {
            Product p = db.Products.SingleOrDefault(n => n.ID == ma);
            return p;
        }
        public int UpdateProduct(Product p)
        {
            db.Entry(p).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return p.ID;
        }
    }
}
