public class Film : Product
{

    public int Duration { get; set; }


    public Film(int serialCode, string title, int year, string category, bool state, int position, string authorName, int duration)
    {
        SerialCode = serialCode;
        Title = title;
        Year = year;
        Category = category;
        State = state;
        Position = position;
        AuthorName = authorName;
        Duration = duration;
    }

}