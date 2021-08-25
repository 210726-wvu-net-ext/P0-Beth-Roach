namespace Models
{
    public class user
    {
        public static addUser()
        {
            Console.WriteLine($"Enter Chosen Username: ");
            Console.ReadLine(userName);
            Console.WriteLine($"Enter a password: ");
            Console.ReadLine(password);
            Console.WriteLine($"Username is {userName} and password is {password}");
        }
    }
    public class admin
    {
        public static adminLogin()
        {
            adminLogin.username = "admin";
            adminLogin.Password = "HelloWorld12";
        }
    }
    public class SearchUsers
    {
        public Restaurant SearchUser(string name)
        {
            return _repo.SearchUser(name);
        }
    }
}