using Models;
using DL.Entities;
using System.Collections.Generic;
using System.Linq;
using Users = Models.Users;

namespace DL
{
    public class userRepo : IUserRepo
    {
        private UserdbContext _context;
        public userRepo(UserdbContext context)
        {
            _context = context;
        }

        public List<Models.Users> GetAllUsers()
        {
            return _context.Users.Select(
                Users => new Models.Users(Users.Id, Users.Name)
            ).ToList();
        }


        public Models.Users SearchUsers(string name)
        {
            Entities.UserdbContext foundUser =  _context.Users
            
            .FirstOrDefault(User => Users.Name == name);
            if(foundUser != null)
            {
                return new Models.Users(foundUser.Id, foundUser.Name);
            }
            return new Models.Users();
        }        
    }
}