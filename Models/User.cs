using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobBoardApp.Models;

public class User
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    [DataType(DataType.EmailAddress)]
    public string Email {get; set; }
    [DataType(DataType.PhoneNumber)]
    public int PhoneNumber { get; set; }
    public int CompanyId { get; set; }
    [ForeignKey(nameof(CompanyId))]
    public Company Company { get; set; }
    public ICollection<JobPosting> PostingsFollowed = new List<JobPosting>();
    public ICollection<Category> CategoriesFollowed = new List<Category>();
}