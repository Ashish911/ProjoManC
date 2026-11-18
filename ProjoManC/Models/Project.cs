namespace ProjoManC.Models;

public class Project
{
    public int ID { get; set; }
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public ProjectStatus Status { get; set; } =  ProjectStatus.NotStarted;
    
    
    public DateTime? DueDate { get; set; }
    
    public int ClientId { get; set; }
    public Client Client { get; set; } = null!;
    
    //public List<User> Users { get; set; }
    
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}