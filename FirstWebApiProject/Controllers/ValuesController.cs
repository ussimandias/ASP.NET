using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FirstWebApiProject.Models;

namespace FirstWebApiProject.Controllers
{
    [Authorize]
    public class ProductController : ApiController
    {
        // GET api/values
        public IEnumerable<Product> Get()
        {
            //return new string[] { "value1", "value2" };
            return Models.Product.Products;
        }

        // GET api/values/5
        public Product Get(int id)
        {
            return Models.Product.Products.FirstOrDefault(p => p.ID == id);
        }

        // POST api/values
        public HttpResponseMessage Post([FromBody]Product value)
        {
            Product.Products.Add(value);

            var response = new HttpResponseMessage(HttpStatusCode.Created);
            response.Headers.Location = new Uri(Url.Link( "DefaultApi", new {id = value.ID}));
            return response;
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]Product value)
        {
            var thisProduct = Product.Products.FirstOrDefault(p => p.ID == id);
            if (thisProduct != null)
            {
                thisProduct.Name = value.Name;
                thisProduct.Price = value.Price;
            }
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            Product.Products.Remove(Product.Products.First(p => p.ID == id));
        }
    }
}
