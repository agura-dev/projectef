using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projectef.Models;

public class Task
{
    [Key]
    public Guid TaskID {get; set;}

    [ForeignKey("CategoryID")]
    public Guid CategoryID {get; set;}

    [Required]
    [MaxLength(200)]
    public string Title {get; set;}

    public string Description {get; set;}

    public Priority TaskPriority { get; set;}

    public DateTime CreationDate {get; set;}

    public virtual Category Category {get; set;}

    [NotMapped]
    public string Summary {get; set;}

}

public enum Priority 
{
    Low,

    Medium,

    High
}
