public class HardCover : IBook
{
    public string Title { get; set; }
    public bool IsBorrowed { get; set; }
    public string Location { get; set; }

    public HardCover(string title)
    {
        Title = title;
        IsBorrowed = false;
        Location = "Library";
    }

    public void MarkAsBorrowed()
    {
        IsBorrowed = true;
        Location = "Client";
    }

    public void MarkAsReturned()
    {
        IsBorrowed = false;
        Location = "Library";
    }

    public string GetLocation()
    {
        return Location;
    }
}
