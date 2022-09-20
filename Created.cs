Bibilioteca bibilioteca = new Bibilioteca();
//nuovo user
User user = new User("Admin", "Fasullo", "Admin@gmial.com", "Prova1234", 12345678910);
//nuovo film
Film film = new Film( 1234556, "Titolo", 2000, "category", false, 5, "User Regista" , 117);
//nuovo book
Book book = new Book(1234556, "Titolo", 2000, "category", false, 5, "User Regista", 420);

bibilioteca.AddUser(user);
bibilioteca.AddMovie(film);
bibilioteca.AddBook(book);