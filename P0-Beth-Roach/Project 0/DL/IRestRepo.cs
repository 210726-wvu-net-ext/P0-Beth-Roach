using System.Collections.Generic;

using Models;

namespace DL
{
    public interface IRestRepo
    {
        List<Restaurant> GetAllRestaurant();

        Rating AddArating(Rating Rating);

        Restaurant SearchRestByName(string name);
    }
}