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
    
        public Restaurant(int id, string name, float Cost, string rating) : this(name)
        {
            this.Id = id;
            
        }

        public int Id {get; set;}
        public string? Name {get;set;}

        public float? Cost { get; set; }
    
    }
    
}
