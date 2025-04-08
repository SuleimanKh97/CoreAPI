using CoreAPI.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoreAPI.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController(MyDbContext db) : ControllerBase
    {
        [HttpGet("getAllCategory")] 
        public IActionResult getAllCategory()
        {
            return  Ok( db.Categories.ToList());

        }

        [HttpGet("getElementByID")]
        public IActionResult getCategoryByID(int id) {
            var category = db.Categories.FirstOrDefault(c => c.CategoryId == id);
            if (category != null)
            {
                return Ok(category);
            }
            else {
                return BadRequest();
            }
        }

        [HttpGet("getCategoryBy{Name}")]
        public IActionResult getCategoryByName(string Name)
        {
            var category = db.Categories.FirstOrDefault(n => n.CategoryName == Name);
            if (category != null)
            {
                return Ok(category);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("getAllCategoryName")]
        public IActionResult getAllCategoryByName(string Name)
        {
            var category = db.Categories.Where(n => n.CategoryName == Name).ToList();
            if (category != null)
            {
                return Ok(category);
            }
            else
            {
                return NotFound();
            }
        }
        [HttpGet("getFirstCategory")]
        public IActionResult getFirstCategory()
        {
            var category = db.Categories.First();
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
