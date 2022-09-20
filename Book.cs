public class Book : Product
{

    public int Pages { get; set; }


    public Book(int serialCode, string title, int year, string category, bool state, int position, string authorName, int pages)
    {
        SerialCode = serialCode;
        Title = title;
        Year = year;
        Category = category;
        State = state;
        Position = position;
        AuthorName = authorName;
        Pages = pages;
    }

}