using Microsoft.AspNetCore.Mvc;
using TaskMasterAPI.Services;

namespace TaskMasterAPI.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class TaskController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<Models.Task>> GetTasks()
    {
        return Ok(TaskDataStore.Current);
    }

    [HttpGet("{id}")]
    public ActionResult<Models.Task> GetTask(int id)
    {
        var task = TaskDataStore.Current.Tasks.FirstOrDefault(t => t.Id == id);

        if (task == null)
            return NotFound("The task was not found.");

        return Ok(task);
    }

    [HttpPost]
    public ActionResult<Models.Task> CreateTask(Models.TaskInsert taskInsert)
    {
        // new task creation
        var newTask = new Models.Task()
        {
            Id = TaskDataStore.Current.Tasks.Max(t => t.Id) + 1, // get the last id and sum up 1 to it
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now,
            IsCompleted = false,
            Title = taskInsert.Title,
            Description = taskInsert.Description
        };

        // adding to tasks list
        TaskDataStore.Current.Tasks.Add(newTask);

        // returning Ok with new task
        return Ok(newTask);
    }

    [HttpPut("{id}")]
    public ActionResult<Models.Task> UpdateTask(int id, Models.TaskInsert taskInsert)
    {
        // we look up for the task
        var task = TaskDataStore.Current.Tasks.FirstOrDefault(t => t.Id == id);

        // handling if task does no exists
        if (task == null)
            return NotFound("The task was not found.");

        // updating task
        task.Title = taskInsert.Title;
        task.Description = taskInsert.Description;
        task.UpdatedAt = DateTime.Now;

        // returns the updated task
        return Ok(task);
    }

    [HttpDelete("{id}")]
    public ActionResult DeleteTask(int id)
    {
        var task = TaskDataStore.Current.Tasks.FirstOrDefault(t => t.Id == id);

        if (task == null)
            return NotFound("The task was not found.");

        // deleting task
        TaskDataStore.Current.Tasks.Remove(task);

        // we return NoContent when a resource is removed
        return NoContent();
    }
}
