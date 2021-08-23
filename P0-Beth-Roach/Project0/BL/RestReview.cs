using Models;
using DL;
using System.Collections.Generic;

namespace BL
{
    public class RestReview : ResReview
    {
        private IRestRepo _repo;

        public RestReview(IRestRepo repo)
        {
            _repo = repo;
        }
        
        public List<Restaurant> ViewAllRestaurants()
        {
            return _repo.GetAllRestaurants();
        }
        public ResReview Rating()
        {
            return _repo.Rating();
        }
        public Restaurant SearchRestByName(string name)
        {
            return _repo.SearchRestByName(name);
        }
    }
}