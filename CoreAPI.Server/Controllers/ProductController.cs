using CoreAPI.Server.DTOs;
using CoreAPI.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreAPI.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController(MyDbContext db) : ControllerBase
    {
        //private readonly DataService _dataService
        //public ProductController(DataService dataService)
        //{
        //    _dataService = dataService;
        //}

        [HttpPut("EditProduct/{id}")]
        public IActionResult editProduct(int id,CreateProductRequest Product)
        {
           var product = db.Products.Find(id);
            if (product != null)
            {
                product.Name = Product.Name;
                product.Description = Product.Description;
                product.Price = Product.Price;
                product.Quantity = Product.Quantity;
                product.UpdatedAt = DateTime.Now;
                db.SaveChanges();
                return Ok(product);
            }
            return BadRequest();
        }

        [HttpDelete("DeleteProductByID/{id}")]
        public IActionResult deleteProductByID(int id)
        {
            var product = db.Products.Find(id);
            if (product != null)
            {
                db.Products.Remove(product);
                db.SaveChanges();
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet("getAllProduct")]
        public IActionResult getAllCategory()
        {
            var product = db.Products.ToList();
            return Ok(product);

        }

        [HttpGet("getProductByID")]
        public IActionResult getCategoryByID(int id)
        {
            var category = db.Products.FirstOrDefault(c => c.Id == id);
            if (category != null)
            {
                return Ok(category);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet("getProductBy{Name}")]
        public IActionResult getCategoryByName(string Name)
        {
            var category = db.Products.FirstOrDefault(n => n.Name == Name);
            if (category != null)
            {
                return Ok(category);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("getAllProductName")]
        public IActionResult getAllCategoryByName(string Name)
        {
            var category = db.Products.Where(n => n.Name == Name).ToList();
            if (category != null)
            {
                return Ok(category);
            }
            else
            {
                return NotFound();
            }
        }
        [HttpGet("getFirstProduct")]
        public IActionResult getFirstCategory()
        {
            var category = db.Products.First();
            if (category != null)
            {
                return Ok(category);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost("addNewProduct")]
        public IActionResult addNewProduct([FromBody] CreateProductRequest Product)
        {
            var product = new Product();
            {
                product.Name = Product.Name;
                product.Description = Product.Description;
                product.Price = Product.Price;
                product.Quantity = Product.Quantity;
                product.CreatedAt = DateTime.Now;
            }
            db.Products.Add(product);
            db.SaveChanges();
            return Ok();
            
        }


    }
}
