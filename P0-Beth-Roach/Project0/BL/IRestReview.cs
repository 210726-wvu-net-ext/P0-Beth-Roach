using Models;
using System.Collections.Generic;

namespace BL
{
    public interface IRestReview
    {
        List<Restaurant> ViewAllRestaurants();
        Restaurant SearchRestByName(string name);
        Restaurant review();
        user addUserLogin();
    }
}