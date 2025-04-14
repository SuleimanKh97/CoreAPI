namespace CoreAPI.Server.DTOs.CategoryDTOs
{
    public class CreateCategoryRequest
    {
        public string CategoryName { get; set; } = null!;

        public string? CategoryDescription { get; set; }
    }
}
