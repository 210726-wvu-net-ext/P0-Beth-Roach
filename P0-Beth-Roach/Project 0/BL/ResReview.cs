using Models;
using System.Collections.Generic;

namespace BL
{
    public interface ResReview
    {
        List<Restaurant> ViewAllRestaurants();
        Rating Ratings(Ratings newRating);
        Details ViewDetails(Restaurant meal);
        Restaurant SearchRestByName(string name);
    }
}