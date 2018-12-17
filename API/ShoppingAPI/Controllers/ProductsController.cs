using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShoppingAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Products/")]
    public class ProductsController : Controller
    {
        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Mechnical Keyboard", Category = "Electronics", Price = 900},
            new Product { Id = 2, Name = "Aesop's Fables", Category = "Books", Price = 230.50M},
            new Product { Id = 3, Name = "Tooth Paste", Category = "Toiletries", Price = 30},
            new Product { Id = 4, Name = "Couch", Category = "Furniture", Price = 1600}
        };

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return products;
        }

        [HttpGet("{id}", Name = "GetProduct")]
        public IActionResult GetById(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null) return NotFound();
            return Ok(product);
        }

    }
}
