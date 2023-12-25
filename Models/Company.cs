using System.ComponentModel.DataAnnotations;
using JobBoardApp.Models.Validation;

namespace JobBoardApp.Models;

public class Company
{
    public int Id { get; set; }
    public string Name { get; set; }
    [LegalEntity]
    public string EntityType { get; set; }
    [EmailAddress]
    public string Email { get; set; }
    [Phone]
    public string PhoneNumber { get; set; }
    public ICollection<JobPosting> JobPostings { get; set; }
}