using Models;
using DL;
using System.Collections.Generic;

namespace BL
{
    public class RestReview : IRestReview
    {
        private IRestRepo _repo;

        public RestReview(RestRepo repo)
        {
            _repo = repo;
        }
        
        public List<Restaurant> ViewAllRestaurants()
        {
            return _repo.GetAllRestaurants();
        }
        public Restaurant SearchRestByName(string name)
        {
            return _repo.SearchRestByName(name);
        }
        public Restaurant review()
        {
            return review();
        }
        public user addUserLogin()
        {
            return addUserLogin();
        }
    }
}