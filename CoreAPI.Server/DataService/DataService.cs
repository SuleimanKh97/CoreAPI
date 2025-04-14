using CoreAPI.Server.DTOs.CategoryDTOs;
using CoreAPI.Server.IDataService;
using CoreAPI.Server.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoreAPI.Server.DataService
{
    public class DataService : CoreAPI.Server.IDataService.IDataService
    {
        private readonly MyDbContext _db;

        public DataService(MyDbContext db)
        {
            _db = db;
        }

        public List<Category> GetAllCategories()
        {
            return _db.Categories.ToList();
        }

        public bool deleteProduct(int id)
        {
            var product = _db.Products.FirstOrDefault(p => p.Id == id);
            if (product != null) { 
                _db.Products.Remove(product);
                _db.SaveChanges();
                return true;
            }
            return false;
        }
        public bool deleteCategory(int id)
        {
            var category = _db.Categories.FirstOrDefault(c => c.CategoryId == id);
            if (category != null)
            {
                _db.Categories.Remove(category);
                _db.SaveChanges();
                return true;
            }
            return false;
        }


        public bool AddCategory([FromBody] CreateCategoryRequest category)
        {


            if (category == null)
                return false;

            var Cat = new Category
            {

                CategoryName = category.CategoryName,
                CategoryDescription = category.CategoryDescription,


            };

            _db.Categories.Add(Cat);
            _db.SaveChanges();

            return true;
        }

        public bool editCategory(int id, CreateCategoryRequest category)
        {
            var editcategory = _db.Categories.Find(id);
            if (editcategory != null) {
                editcategory.CategoryName = category.CategoryName;
                editcategory.CategoryDescription = category.CategoryDescription;
                _db.SaveChanges();
                return true;
            }
            return false ;


        }
    }
}