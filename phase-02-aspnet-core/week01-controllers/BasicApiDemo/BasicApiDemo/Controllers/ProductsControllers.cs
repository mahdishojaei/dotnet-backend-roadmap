using BasicApiDemo.Models;
using Microsoft.AspNetCore.Mvc;


namespace BasicApiDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {


        private static int _nextId = 1;
        private static readonly List<Product> _products = new()  
        {
            new Product { Id = _nextId++, Name = "Laptop", Price = 1200.00m, IsAvailable = true },
            new Product { Id = _nextId++, Name = "Mouse", Price = 25.00m, IsAvailable = true },
            new Product { Id = _nextId++, Name = "Keyboard", Price = 75.00m, IsAvailable = false }
        };



        // GET api/products
        [HttpGet]
        public IActionResult GetAll()  
        {
            return Ok(_products);
        }



        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);  
            if (product is null)
                return NotFound($"Product with id {id} not found.");

            return Ok(product);
        }


        // POST api/products

        [HttpPost]
        public IActionResult Create([FromBody] Product product)
        {
            product.Id = _nextId++;
            _products.Add(product);
            return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Product updated)
        {
            var existing = _products.FirstOrDefault(p => p.Id == id);
            if (existing is null)
                return NotFound($"Product with id {id} not found.");

            existing.Name = updated.Name;
            existing.Price = updated.Price;
            existing.IsAvailable = updated.IsAvailable;

            return Ok(existing);
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product is null)
                return NotFound($"Product with id {id} not found.");

            _products.Remove(product);
            return NoContent();
        }
    }
}
