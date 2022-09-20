public class Book : Product
{

    public int Pages { get; set; }
    public string ISBN { get; set; }


    public Book(string title, int year, string category, int position, string authorName, int pages, string isbn ) : base(title, year, category, position, authorName)
    {
        Pages = pages;
        ISBN = isbn;
    }

}