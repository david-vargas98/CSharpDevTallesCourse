partial class Program
{
    static void ShowEmployees()
    {
        // Instantiating employees list
        List<Employee> employees = [];

        // Adding employees to list
        employees.AddRange
        (
            new TeamLeader("Carlos", 5000),
            new Developer("Ana", 4000),
            new TeamLeader("Laura", 6000),
            new Developer("Luis", 3500)
        );

        // Going through the list of employees
        WriteLine("Employees details:\n");
        foreach (Employee employee in employees)
        {
            employee.ShowInfo();
        }
    }

    // Base class
    class Employee
    {
        protected string? Name { get; set; }
        protected double Salary { get; set; }
        protected string? Position { get; set; }
        public Employee(string name, double salary, string position)
        {
            Name = name;
            Salary = salary;
            Position = position;
        }
        public virtual double CalculateBonus()
        {
            return Salary * 0.05;
        }
        public void ShowInfo()
        {
            WriteLine($"Name: {Name}, Position: {Position}, Salary: {Salary:C}, Bonus: {CalculateBonus():C}");
        }
    }

    // Derived classes
    class TeamLeader : Employee
    {
        public TeamLeader(string name, double salary) : base(name, salary, "Team Leader") { }
        public override double CalculateBonus()
        {
            return Salary * 0.10;
        }
    }

    class Developer : Employee
    {
        public Developer(string name, double salary) : base(name, salary, "Developer") { }
        public override double CalculateBonus()
        {
            return Salary * 0.07;
        }
    }
}