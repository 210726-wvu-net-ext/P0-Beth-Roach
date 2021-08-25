using DL.Entities;
using System.Collections.Generic;
using System.Linq;
using Users = Models.Users;

namespace DL
{
    public class userRepo : IUserRepo
    {
        private UserdbContext _Context;
        public userRepo(UserdbContext context)
        {
            _Context = context;
        }

        public List<Models.Users> GetAllUsers()
        {
            return _Context.Users.Select(
                Users => new Models.Users(Users.Id, Users.Name)
            ).ToList();
        }


        public Models.Users SearchUsers(string name)
        {
            Entities.Users foundUser =  _Context.Users
            
            .FirstOrDefault(u => u.Name == name);
            if(foundUser != null)
            {
                return new Models.Users(foundUser.Id, foundUser.Name);
            }
            return new Models.Users();
        } 
               
    }
}