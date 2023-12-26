using System.ComponentModel.DataAnnotations;
using JobBoardApp.Models.Validation;

namespace JobBoardApp.Models;

public class Company : User
{
    public string Name { get; set; }
    [LegalEntity]
    public string EntityType { get; set; }
    
}