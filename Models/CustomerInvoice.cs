public class CustomerInvoice {
    public int InvoiceID { get; set; }
    public int ProjectID { get; set; }
    public int CustomerID { get; set; }
    public decimal Amount { get; set; }
    public DateTime InvoiceDate { get; set; }
    public DateTime DueDate { get; set; }
    public string Status { get; set; }
}