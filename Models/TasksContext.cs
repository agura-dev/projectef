using Microsoft.EntityFrameworkCore;
using projectef.Models;

namespace projectef;

public class TasksContext: DbContext
{
    public DbSet<Category> Categories{get; set;}
    public DbSet<Models.Task> Tasks {get; set;}

    //metodo base del contructor
    public TasksContext(DbContextOptions<TasksContext> options) : base(options){ }
}