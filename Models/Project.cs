public class Project
{
    public int ProjectID { get; set; }
    public string ProjectName { get; set; }
    public int ClientID { get; set; }
    public string Location { get; set; }
    public decimal BudgetAmount { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Status { get; set; }
}