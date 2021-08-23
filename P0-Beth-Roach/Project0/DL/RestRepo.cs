using Models;
using DL.Entities;
using System.Collections.Generic;
using System.Linq;

namespace DL
{
    public class RestRepo : IRestRepo
    {
        private RestaurantdbContext _context;
        public RestRepo(RestaurantdbContext context)
        {
            _context = context;
        }

        public List<Models.Restaurant> GetAllRestaurant()
        {
            return _context.Restaurant.Select(
                Restaurant => new Models.Restaurant(Restaurant.Id, Restaurant.Name, Restaurant.Cost, Restaurant.Ratings)
            ).ToList();
        }


        public Models.Restaurant SearchRestByName(string name)
        {
            Entities.Restaurant foundRestaurant =  _context.Restaurant
                .FirstOrDefault(Restaurant => Restaurant.Name == name);
            if(foundRestaurant != null)
            {
                return new Models.Restaurant(foundRestaurant.Id, foundRestaurant.Name, foundRestaurant.Cost, foundRestaurant.Ratings);
            }
            return new Models.Restaurant();
        }        
    }
}