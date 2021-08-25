using System.Collections.Generic;
using Models;


namespace DL
{
    public interface IUserRepo
    {
        List<Users> GetAllUsers();

        Users SearchUsers(string name);
    }
}