using System;

namespace BankingKata.Controllers
{
    public class AccountSummaryViewModel
    {
        public DateTime LastTransactionDate { get; set; }
        public decimal LastTransactionAmount { get; set; }
        public decimal CurrentBalance { get; set; }
    }
}