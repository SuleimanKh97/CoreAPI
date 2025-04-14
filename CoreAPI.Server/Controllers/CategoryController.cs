using CoreAPI.Server.DTOs.CategoryDTOs;
using CoreAPI.Server.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CoreAPI.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
  
            private readonly CoreAPI.Server.IDataService.IDataService _dataService;
            private readonly MyDbContext _db;

            public CategoryController(CoreAPI.Server.IDataService.IDataService dataService , MyDbContext db)
            {
                _dataService = dataService;
                _db = db;
            }

            [HttpGet("getAllCategory")]
            public IActionResult GetAllCategory()
            {
            var categories = _dataService.GetAllCategories();
                return Ok(categories);
            }


        [HttpDelete("DeleteCategoryByID/{id}")]
        public IActionResult DeleteCategory(int id) {
            var category = _dataService.deleteCategory(id);
            if (category != false)
                return Ok();
            return BadRequest();
        
        }


        [HttpGet("getElementByID")]
        public IActionResult getCategoryByID(int id) {
            var category = _db.Categories.FirstOrDefault(c => c.CategoryId == id);
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
            var category = _db.Categories.FirstOrDefault(n => n.CategoryName == Name);
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
            var category = _db.Categories.Where(n => n.CategoryName == Name).ToList();
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
            var category = _db.Categories.First();
            if (category != null)
            {
                return Ok(category);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost("addCategory")]
        public IActionResult AddCategory([FromBody] CreateCategoryRequest category)
        {
           bool caategory =  _dataService.AddCategory(category);

            if (caategory == false)
                return BadRequest();

           
            return Ok("Category Added Successfully");
        }

        [HttpPut("editCategory/{id}")]
        public IActionResult editCategory(int id, CreateCategoryRequest category)
        {
            if(category == null)
            {
                return BadRequest();
            }
            bool cate = _dataService.editCategory(id, category);
            if (cate)
            {
                return Ok("Category Edited Successfully");
            }
            return NotFound();    
        }

    }
}
