namespace JobBoardApp.Models;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Technologies Technologies { get; set; }
}

public enum Technologies
{
    CSharp,
    Java,
    Python,
    Javascript,
    Bash,
    Docker,
    Kubernetes,
    Linux,
    SQL,
    CPlusPlus,
    Git,
    Azure,
    AWS,
    Ruby,
    Kotlin,
    Swift
}