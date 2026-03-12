using System;

namespace DesignTattva.Models
{
    public class Expense
    {
        public int ExpenseID { get; set; }
        public int ProjectID { get; set; }
        public int VendorID { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string InvoiceNumber { get; set; }
    }
}