using System.ComponentModel.DataAnnotations;

namespace projectef.Models;

public class Category
{
    [Key]
    public Guid CategoryID {get; set;}

    [Required]
    [MaxLength(150)]
    public string Name {get; set;}

    public string Description {get; set;}

    public virtual ICollection<Task> Task{get; set;}
}