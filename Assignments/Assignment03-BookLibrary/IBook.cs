public interface IBook
{
    void MarkAsBorrowed();
    void MarkAsReturned();
    string GetLocation();
}