using System.Collections.Generic;

namespace Models
{
    public class Users
    {
        public Users(object id, object name)
        {
        }

        public Users()
        {
        }

        public void User(int id, string name) //: this(name)
        {
            this.Id = id;
            this.Name = name;
        }
        public int Id { get; set;}
        public string? Name { get;set;}
    
    }
    
}
