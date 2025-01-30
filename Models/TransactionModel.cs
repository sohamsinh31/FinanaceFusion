// using Microsoft.VisualBasic.ApplicationServices;

namespace FinanceFusion.Models
{

    public class TransactionModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime UpdatedDateTime { get; set; }
        public string Description { get; set; }

    }
}