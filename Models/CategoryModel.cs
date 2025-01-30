namespace FinanceFusion.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }
        public string? CategoryName { get; set; }
        public int UserId { get; set; }
        public int TypeId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime UpdatedDateTime { get; set; }
        public bool IsActive { get; set; }
    }
}