using System.Collections.Generic;

namespace DL.Entities
{
    public class Users
    {
        public Users(object id, object name)
        {
        }

        public void User(int id, string name) //: this(name)
        {
            this.Id = id;
            this.Name = name;
        }
        public Users(int id)
        {
            this.Id = id;

        }
        public int Id { get; set; }
        public string? Name { get; set; }

    }

}
