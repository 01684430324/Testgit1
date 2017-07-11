using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Model.DAO;
using Model.EF;
namespace Api_Codefirst.Models
{
    public class ProductController : ApiController
    {
        public IEnumerable<Product> GetAll()
        {
            var dao = new ProductDAO();
            var list = dao.GetAll();
            return list;
        }

        public Product GetID(int id)
        {
            var dao = new ProductDAO();
           return dao.GetID(id);


        }

        public IHttpActionResult AddProduct(Product p)
        {
            var dao = new ProductDAO();
            dao.AddProduct(p);
            return Ok();
        }

        public IHttpActionResult DeleteProduct(int id)
        {
            var dao = new ProductDAO();
            dao.DeleteProduct(id);
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult UpdateProduct(Product p)
        {
            int id = p.ID;
            var dao = new ProductDAO();
            dao.UpdateProduct(p);
            return Ok();
        }
    }
}
