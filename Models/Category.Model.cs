namespace FundTransfer
{
    public class Category
    {
        public int Id { get; set; }
        public string? CategoryName { get; set; }
        public int UserId { get; set; }
        public int TypeId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool IsActive { get; set; }
    }
}