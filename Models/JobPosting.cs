using System.ComponentModel.DataAnnotations.Schema;

namespace JobBoardApp.Models;

public class JobPosting
{
    public int Id { get; set; }
    public string Category { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int OwnerId { get; set; }
    [ForeignKey("OwnerId")]
    public User Owner { get; set; }
    
    public decimal SalaryGross { get; set; }
    public decimal SalaryNet { get; set; }
}