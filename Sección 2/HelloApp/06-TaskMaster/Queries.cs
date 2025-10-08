using BetterConsoleTables;

namespace TaskMaster
{
    public class Queries(List<Task> _tasks)
    {
        private List<Task> Tasks = _tasks;

        // Methods to be developed:
        public void ListTasks()
        {
            ForegroundColor = ConsoleColor.DarkBlue;
            WriteLine("\t-----Tasks list-----");

            // BetterConsoleTables library to show table in a prettier way 
            Table table = new("Id", "Description", "State");
            foreach (var task in Tasks)
            {
                table.AddRow(task.Id, task.Description, task.Completed ? "Completed" : "");
            }

            table.Config = TableConfiguration.Unicode();

            Write(table.ToString());
            ReadKey();
        }

        public List<Task> AddTask()
        {
            try
            {
                ResetColor();
                Clear();
                WriteLine("\t----Add Task----");
                WriteLine("Enter the task description: ");

                var description = ReadLine();
                Task newTask = new(Utils.GenerateId(), description!);
                Tasks.Add(newTask);

                ForegroundColor = ConsoleColor.Green;
                WriteLine("Task successfully added.");
                ResetColor();

                return Tasks;
            }
            catch (Exception ex)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine(ex.Message);
                return Tasks;
            }
        }

        public List<Task> MarkAsCompleted()
        {
            try
            {
                ResetColor();
                Clear();
                WriteLine("\t----Mark task as completed----");
                Write("Enter the id of the task you desire to mark as completed: ");

                var id = ReadLine();
                Task task = Tasks.Find(t => t.Id == id)!;

                if (task == null)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("The task was not found, ID does not exists.");
                    ResetColor();

                    return Tasks;
                }

                task.Completed = true;
                task.ModifiedAt = DateTime.Now;

                ForegroundColor = ConsoleColor.Green;
                WriteLine("Task was successfully marked as completed.");
                ResetColor();

                return Tasks;
            }
            catch (Exception ex)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine(ex.Message);
                return Tasks;
            }
        }

        public List<Task> EditTask()
        {
            try
            {
                ResetColor();
                Clear();
                WriteLine("\t----Edit task----");
                Write("Enter the id of the task you desire to edit: ");

                var id = ReadLine();
                Task task = Tasks.Find(t => t.Id == id)!;

                if (task == null)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("The task was not found, ID does not exists.");
                    ResetColor();

                    return Tasks;
                }

                WriteLine("Enter the task description:");
                var description = ReadLine();

                task.Description = description;
                task.ModifiedAt = DateTime.Now;

                ForegroundColor = ConsoleColor.Green;
                WriteLine("Task was successfully edited.");
                ResetColor();

                return Tasks;
            }
            catch (Exception ex)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine(ex.Message);
                return Tasks;
            }
        }

        public List<Task> RemoveTask()
        {
            try
            {
                ResetColor();
                Clear();
                WriteLine("\t----Remove task----");
                Write("Enter the id of the task you desire to remove: ");

                var id = ReadLine();
                Task task = Tasks.Find(t => t.Id == id)!;

                if (task == null)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("The task was not found, ID does not exists.");
                    ResetColor();

                    return Tasks;
                }

                Tasks.Remove(task);

                ForegroundColor = ConsoleColor.Green;
                WriteLine("Task was successfully removed.");
                ResetColor();

                return Tasks;
            }
            catch (Exception ex)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine(ex.Message);
                return Tasks;
            }
        }

        public void TasksByState()
        {
            Clear();
            try
            {
                ResetColor();
                WriteLine("\t----Tasks by state----");
                WriteLine("1. Completed");
                WriteLine("2. Pending");
                WriteLine("Select an option: ");
                string taskState = ReadLine()!;

                if (taskState != "1" && taskState != "2")
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("Non-valid option!");
                    ResetColor();
                    return;
                }

                bool completed = taskState == "1";
                List<Task> filteredTasks = Tasks.Where(t => t.Completed == completed).ToList();

                if (filteredTasks.Count == 0)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("Tasks with specified state were not found!");
                    ResetColor();
                    return;
                }

                ForegroundColor = completed ? ConsoleColor.Green: ConsoleColor.Red;
                
                Table table = new("Id", "Description", "State");
                foreach (var task in filteredTasks)
                {
                    table.AddRow(task.Id, task.Description, task.Completed ? "Completed" : "");
                }

                table.Config = TableConfiguration.Unicode();

                Write(table.ToString());
                ReadKey();
            }
            catch (Exception ex)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine($"An error have occurred while filtering tasks: {ex.Message}");
            }
        }

        public void TasksByDescription()
        {
            Clear();
            try
            {
                ResetColor();
                WriteLine("\t----Tasks by description----");

                WriteLine("Please, enter the description: ");
                string description = ReadLine()!;

                List<Task> matchingTasks = Tasks.FindAll(t => t.Description?.Contains(description, StringComparison.OrdinalIgnoreCase) ?? false);

                if (matchingTasks.Count == 0)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("Tasks with specified description were not found!");
                    ResetColor();
                    return;
                }

                Table table = new("Id", "Description", "State");
                foreach (var task in matchingTasks)
                {
                    table.AddRow(task.Id, task.Description, task.Completed ? "Completed" : "");
                }

                table.Config = TableConfiguration.Unicode();

                Write(table.ToString());
                ReadKey();
            }
            catch (Exception ex)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine($"An error have occurred while filtering tasks by description: {ex.Message}");
            }
        }
    }
} 