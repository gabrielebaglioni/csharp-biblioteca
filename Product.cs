public class Product
{
   
    public string Title { get; set; }
    public int Year { get; set; }
    public string Category { get; set; }
    public bool State { get; set; }
    public int Position { get; set; }
    public string AuthorName { get; set; }

    public Product( string title, int year, string category, int position, string authorName)
    {
        Title = title;
        Year = year;
        Category = category;
        State = false;
        Position = position;
        AuthorName = authorName;
       
    }


}