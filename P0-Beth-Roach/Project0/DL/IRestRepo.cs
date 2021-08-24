using System.Collections.Generic;
using Models;


namespace DL
{
    public interface IRestRepo
    {
        List<Restaurant> GetAllRestaurants();

        //Rating AddARating(Rating Rating);

        Restaurant SearchRestByName(string name);
    }
}