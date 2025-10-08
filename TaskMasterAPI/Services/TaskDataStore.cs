namespace TaskMasterAPI.Services;

public class TaskDataStore
{
    public List<Models.Task> Tasks { get; set; }

    public static TaskDataStore Current { get; } = new TaskDataStore();

    public TaskDataStore()
    {
        Tasks =
        [
          new Models.Task(){
            Id = 1,
            Title = "Learn C#",
            Description = "Learn C# fundamentals",
            IsCompleted = false,
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        },
        new Models.Task(){
            Id = 2,
            Title = "Learn ASP.NET Core",
            Description = "Learn ASP.NET Core fundamentals",
            IsCompleted = false,
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        },
        new Models.Task(){
            Id = 3,
            Title = "Learn Entity Framework Core",
            Description = "Learn Entity Framework Core fundamentals",
            IsCompleted = false,
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        }
        ];
    }
}
