namespace JobBoardApp.Models;

public class CategoryAndUserDTO
{
    public User User { get; set; }
    public IEnumerable<Category> Categories { get; set; }
}