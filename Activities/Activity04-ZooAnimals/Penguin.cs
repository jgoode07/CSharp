public class Penguin : Animal, ISwim
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

    public void Swim()
    {
        Console.WriteLine($"{Name} is swimming!");
    }
}