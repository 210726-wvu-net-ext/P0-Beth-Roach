using Models;
using System.Collections.Generic;

namespace BL
{
    public interface ResReview
    {
        List<Restaurant> ViewAllRestaurants();
        Ratings Ratings(Ratings newRating);
        Restaurant SearchRestByName(string name);
    }
}