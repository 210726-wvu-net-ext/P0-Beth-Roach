using Models;
using System.Collections.Generic;

namespace BL
{
    public interface ResReview
    {
        List<Restaurant> ViewAllRestaurants();
        Ratings Rating(Ratings newRating);
        //Details ViewDetails(Restaurant meal);
        Restaurant SearchRestByName(string name);
    }
}