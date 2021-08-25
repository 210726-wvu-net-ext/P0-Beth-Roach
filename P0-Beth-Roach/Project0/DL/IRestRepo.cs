using System.Collections.Generic;
using Models;


namespace DL
{
    public interface IRestRepo
    {
        List<Restaurant> GetAllRestaurants();

        //Restaurant SelectARestaurant();
        Restaurant SearchRestByName(string name);
    }
}