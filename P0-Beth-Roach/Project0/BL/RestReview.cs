using Models;
using DL;
using System.Collections.Generic;

namespace BL
{
    public class ResReview : RestReview
    {
        private IRestRepo _repo;

        public ResReview(IRestRepo repo)
        {
            _repo = repo;
        }
        
        public List<Restaurant> ViewAllRestaurant()
        {
            return _repo.GetAllRestaurant();
        }

        public Restaurant SearchRestaurantByName(string name)
        {
            return _repo.SearchRestaurantByName(name);
        }
    }
}