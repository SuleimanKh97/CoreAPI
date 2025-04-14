using CoreAPI.Server.DTOs.CategoryDTOs;
using CoreAPI.Server.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreAPI.Server.IDataService
{
    public interface IDataService
    {
        List<Category> GetAllCategories();
        public bool deleteCategory(int id);
        public bool deleteProduct(int id);


        public bool AddCategory(CreateCategoryRequest category);

        public bool editCategory(int id, CreateCategoryRequest category);


    }
}
