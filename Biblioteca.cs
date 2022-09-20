public class Bibilioteca
{
    
    List<User> Users = new List<User>();
   
    List<Film> Films = new List<Film>();

    List<Book> Books = new List<Book>();
 
    public void AddUser(User utente)
    {
        Users.Add(utente);
        utente.isRegistred = true;
    }
    public void RemoveUser(User utente)
    {
        Users.Remove(utente);
        utente.isRegistred = false;
    }
  
    public void AddMovie(Film movie)
    {
       Films.Add(movie);
    }
    public void RemoveMovie(Film movie)
    {
        Films.Remove(movie);
    }
   
    public void AddBook(Book book)
    {
        Books.Add(book);
    }
    public void RemoveBook(Book book)
    {
        Books.Remove(book);
    }



    public List<Product>SearchProduct(string search)
    {
        List<Product> resaults = new List<Product>();


        foreach (Film film in Films)
        {
            if (film.Title == search || film.Serial == search)
            {
                resaults.Add(film);
            }
        }
        foreach (Book book in Books)
        {
            if (book.Title.Contains(search)|| book.ISBN == search )
            {
                resaults.Add(book);
            }
        }
        return resaults;
        
    }
}