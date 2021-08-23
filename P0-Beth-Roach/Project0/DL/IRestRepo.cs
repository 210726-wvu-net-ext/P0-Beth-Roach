using System.Collections.Generic;
using Models;

namespace DL
{
    public interface IRestRepo
    {
        List<Restaurant> GetAllRestaurant();

        //Ratings AddARating(Rating Rating);

        Restaurant SearchRestByName(string name);
    }
}