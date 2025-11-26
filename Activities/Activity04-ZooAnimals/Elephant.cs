public class Elephant : Animal
{
    public Elephant(string name, int age) : base(name, age)
    {
    }

    public string Trumpet()
    {
        return "The elephant blasts a loud trumpet!";
    }

    public override string MakeSound()
    {
        return "Trumpet!";
    }
}