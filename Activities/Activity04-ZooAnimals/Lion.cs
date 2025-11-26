public class Lion : Animal
{
    public Lion(string name, int age) : base(name, age)
    {
    }

    public string Roar()
    {
        return "The lion lets out a deep roar!";
    }

    public override string MakeSound()
    {
        return "Roar!";
    }
}