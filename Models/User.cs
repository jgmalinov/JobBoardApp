using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace JobBoardApp.Models;

public abstract class User : IdentityUser
{
    public ICollection<JobPosting> PostingsFollowed = new List<JobPosting>();
    public ICollection<JobPosting> PostingsSubmitted = new List<JobPosting>();
    public ICollection<Category> CategoriesFollowed = new List<Category>();
}