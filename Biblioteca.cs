public class Bibilioteca
{
    
    List<User> Users = new List<User>();
   
    List<Film> Films = new List<Film>();

    List<Book> Books = new List<Book>();
 
    public void AddUser(User utente)
    {
        Users.Add(utente);
    }
    public void RemoveUser(User utente)
    {
        Users.Remove(utente);
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
}