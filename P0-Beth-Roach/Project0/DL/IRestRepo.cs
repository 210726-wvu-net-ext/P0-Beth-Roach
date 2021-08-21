using System.Collections.Generic;

using Models;

namespace DL
{
    public interface IRestRepo
    {
        List<Restaurant> GetAllRestaurant();

        Ratings AddArating(Ratings Rating);

        Restaurant SearchRestByName(string name);
    }
}