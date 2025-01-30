using Microsoft.VisualBasic.ApplicationServices;

namespace FundTransfer
{

    public class Transaction
    {
        public int TransactionId { get; set; }
        public User? UserID { get; set; }
        public required int CategoryId { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }

        public string Description {get; set;}

    }
}