public class Penguin : Animal
{
    public Penguin(string name, int age) : base(name, age)
    {
    }

    public string Honk()
    {
        return "The penguin makes a funny honking sound!";
    }

    public override string MakeSound()
    {
        return "Honk!";
    }
}
