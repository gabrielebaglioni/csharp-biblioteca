public class User
{

    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string Password { get;  }
    public double Number { get; set; }
    public bool isRegistred { get; set; }


    public User(string name, string surname, string email, string password, double number)
    {
        Name = name;
        Surname = surname;
        Email = email;
        Password = password;
        Number = number;
    }
}