public interface IBook
{
    string Title { get; }
    bool IsBorrowed { get; }
    string Location { get; }

    void MarkAsBorrowed();
    void MarkAsReturned();
    string GetLocation();
}