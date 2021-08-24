
using Entity = RestaurantDL.Entities;
using System.Diagnostics;



//install Microsoft.EntityFrameworkCore.Sqlite for mocking db 

namespace RestaurantTest;

[DebuggerDisplay( "{GetDebuggerDisplay(),nq}") ]
public class NewBaseType
{
    [Fact]

    public void GetAllRestaurantsShouldGetAllRestaurants()

    {

        using (var context = new Entity.RestaurantdbContext(options))

        {

            IRestRepo _repo = new RestRepo(context);



            var Rests = _repo.GetAllRestaurants();



            object p = Assert.Equal(2, Restaurants.Count);

        }

    }
}





 

 