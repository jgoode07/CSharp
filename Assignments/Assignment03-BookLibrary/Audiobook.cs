public class Audiobook : IBook
{
    public string Title { get; set; }
    public bool IsBorrowed { get; set; }
    public string Location { get; set; }

    public Audiobook(string title)
    {
        Title = title;
        IsBorrowed = false;
        Location = "Web";
    }

    public void MarkAsBorrowed()
    {
        IsBorrowed = true;
    }

    public void MarkAsReturned()
    {
        IsBorrowed = false;
    }

    public string GetLocation()
    {
        return Location;
    }
}