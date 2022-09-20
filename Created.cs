Bibilioteca bibilioteca = new Bibilioteca();
//nuovo user
User user = new User("Admin", "Fasullo", "Admin@gmial.com", "Prova1234", 12345678910);
//nuovo film
Film film = new Film(  "Titolo", 2000, "category",  5, "User Regista", "1234567", 117);
//nuovo book
Book book = new Book( "libro", 1900, "categoory",  6, "User Scrittore", 420, "5676862");

bibilioteca.AddUser(user);
bibilioteca.AddMovie(film);
bibilioteca.AddBook(book);




