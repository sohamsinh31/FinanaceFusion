using Microsoft.VisualBasic.ApplicationServices;

namespace FundTransfer
{

    public class Transaction
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public decimal Amount { get; set; }
        public int CategoryId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public string Description { get; set; }

    }
}