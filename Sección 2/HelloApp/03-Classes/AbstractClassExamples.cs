partial class Program
{
    static void AbstractClassExamples()
    {
        // polymorphism applied to classes:
        HomeAppliance myWasher = new WashingMachine()
        {
            Brand = "Samsung"
        };

        HomeAppliance myMicrowave = new Microwave()
        {
            Brand = "DG"
        };

        myWasher.ShowBrand();
        myWasher.TurnOn();

        myMicrowave.ShowBrand();
        myMicrowave.TurnOn();
    }
}

abstract class HomeAppliance()
{
    public string? Brand { get; set; }
    public abstract void TurnOn(); // abstract method
    public void ShowBrand() // concrete method
    {
        WriteLine($"The household appliance brand is: {Brand}");
    }
}

class WashingMachine : HomeAppliance
{
    public override void TurnOn()
    {
        WriteLine("The washing machine has started the wash cycle.");
    }
}

class Microwave : HomeAppliance
{
    public override void TurnOn()
    {
        WriteLine("The microwave is heating the food.");
    }
}