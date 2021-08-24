using Models;
using System.Collections.Generic;

namespace BL
{
    public interface ResReview
    {
        List<Restaurant> ViewAllRestaurants();
        //Rating Rating(Rating newRating);
        Restaurant SearchRestByName(string name);
    }
}