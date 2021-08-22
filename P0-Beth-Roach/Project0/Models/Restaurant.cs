using System.Collections.Generic;

namespace Models
{
    public class Restaurant
    {
        public Restaurant() {}
        public Restaurant(string name)
        {
            this.Name = name;
        }
    
        public Restaurant(int id, string name, float rating, string Cost) : this(name)
        {
            this.Id = id;
            this.rating=rating;
            
        }
        public int Id {get; set;}
        public string Name {get;set;}
        public float rating { get; set; }

        public string Cost { get; set; }
    
    }

}
