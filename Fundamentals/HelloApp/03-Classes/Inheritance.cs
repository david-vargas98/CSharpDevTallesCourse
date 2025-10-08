partial class Program
{
    static void Inheritance()
    {
        HogwartsStudent student = new()
        {
            Name = "Harry Potter",
            House = "Gryffindor"
        };

        HogwartsProfessor professor = new()
        {
            Name = "Severus Snape",
            Subject = "Potions"
        };

        student.Greet();
        student.ShowHouse();

        professor.Greet();
        professor.MySubject();
    }

    class Character
    {
        public string? Name { get; set; }
        public virtual void Greet()
        {
            WriteLine($"Hello, I'm {Name}");
        }
    }

    class HogwartsStudent : Character
    {
        public string? House { get; set; }

        public override void Greet()
        {
            //base.Greet(); // calls original method
            WriteLine($"Hello, I'm {Name} and I'm a student");
        }
        public void ShowHouse()
        {
            WriteLine($"I belong to the {House} hogwarts house.");
        }
    }

    class HogwartsProfessor : Character
    {
        public string? Subject { get; set; }

        public override void Greet()
        {
            WriteLine($"Hello, I'm {Name} and I'm a professor");
        }
        public void MySubject()
        {
            WriteLine($"I teach the {Subject} subject.");
        }
    }
}