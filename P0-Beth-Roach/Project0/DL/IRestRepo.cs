using System.Collections.Generic;

using Models;

namespace DL
{
    public interface IRestRepo
    {
        List<Restaurant> GetAllRestaurant();

        BL.Rating AddARating(Ratings Rating);

        Restaurant SearchRestByName(string name);
    }
}