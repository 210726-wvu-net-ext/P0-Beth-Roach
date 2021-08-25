using System;
using System.Collections.Generic;
using DL;
using BL;
namespace Models
{
    public class user
    {
        public static void addUser()
        {
            Console.WriteLine($"Enter Chosen Username: ");
            string username = Console.ReadLine();
            Console.WriteLine($"Enter a password: ");
            string password = Console.ReadLine();
            Console.WriteLine($"Username is {username} and password is {password}");
            
        }
    }
    
    public class admin
    {
        public admin()
        {
            this.username = "admin";
            this.password = "HelloWorld12";
        }
        public string username {get; set;}
        public string password {get; set; }

        public bool Adminlogin(string uName, string pw)
        {
            return (uName == this.username && pw == this.password);
        }

    }
    

    public class SearchUsers
    {
        private userRepo _repo;
        public SearchUsers(userRepo repo)
        {
            _repo = repo;
        }

        public Users SearchallUser(string name)
        {
            return _repo.SearchUsers(name);
        }
    }
    public class ViewUsers
    {
        private userRepo _repo;
        public ViewUsers(userRepo repo)
        {
            _repo = repo;
        }
        public List<Users> ViewAllUsers()
        {
            return _repo.GetAllUsers();
        }
    }
}