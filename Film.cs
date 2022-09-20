


public class Film : Product
{

    public string Serial { get; set; }
    public int Duration { get; set; }

    public Film(string title, int year, string category, int position, string authorName, string serial, int duration) : base(title, year, category, position, authorName)
    {
        Serial = serial;
        Duration = duration;
    }

}