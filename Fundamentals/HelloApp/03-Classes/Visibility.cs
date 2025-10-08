partial class Program
{
    static void Visibility()
    {
        Jedi jedi = new()
        {
            PowerLevel = 5000,
            LightSaberColor = "Blue"
        };

        jedi.UseForce();
        WriteLine(jedi.PublicField);
        // WriteLine(jedi.PrivateField); // not accessible since it's private
        // WriteLine(jedi.ProtectedField); // not accessible since it's protected

        jedi.RevealSecrets(); // this method exposes both private and protected fields

        // instantiation sith class
        WriteLine("\nSith properties/methods");
        Sith sith = new()
        {
            PowerLevel = 4000,
            LightSaberColor = "Red"
        };
        sith.UseForce();
        //sith.ShowProtected();
    }
}

// contract which forces a class to implement properties and methods
interface IForceUser
{
    int PowerLevel { get; set; }
    string? LightSaberColor { get; set; }
    void UseForce();
}

class Jedi : IForceUser
{
    // public modifier, this property will be accessible from any other part of the code
    public string PublicField = "I'm a Jedi and my power is well-known.";

    // private modifier, only the class members can access it
    private string PrivateField = "My more deeper thoughts are private.";

    // protected modifier, only the class itself and the classes which derives from it are able to access this property
    protected string ProtectedField = "The dark side must not know my secrets.";

    public int PowerLevel { get; set; }
    public string? LightSaberColor { get; set; }
    public void UseForce()
    {
        WriteLine($"I'm a Jedi with a {LightSaberColor} light saber and my power level is {PowerLevel}.");
    }
    private static void Meditate()
    {
        WriteLine($"I'm in a deeper meditation with the force.");
    }
    protected static void Train()
    {
        WriteLine("I'm training to become the best Jedi.");
    }
    public void RevealSecrets()
    {
        WriteLine(ProtectedField);
        WriteLine(PrivateField);
    }
}

class Sith : Jedi, IForceUser
{
    public new void UseForce()
    {
        WriteLine($"I'm a Sith with a {LightSaberColor} light saber and my power level is {PowerLevel}.");
    }
    public void ShowProtected()
    {
        WriteLine(ProtectedField);
        Train();
    }
}