using CoreAPI.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreAPI.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController(MyDbContext db) : ControllerBase
    {

        [HttpGet("getAllProduct")]
        public IActionResult getAllCategory()
        {
            return Ok(db.Products.ToList());

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
        [HttpGet("getFirstProductt")]
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


    }
}
