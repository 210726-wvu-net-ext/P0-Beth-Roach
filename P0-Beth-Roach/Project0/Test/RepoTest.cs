using Xunit;

using Microsoft.EntityFrameworkCore;

using Entity = RestaurantDL.Entities;

using Models;

using RestaurantDL;
using System.Diagnostics;



//install Microsoft.EntityFrameworkCore.Sqlite for mocking db 

namespace RestaurantTest;

[DebuggerDisplay("{GetDebuggerDisplay(),nq}")]
public class NewBaseType
{
    [Fact]

    public void GetAllRestaurantsShouldGetAllRestaurants()

    {

        using (var context = new Entity.RestaurantdbContext(options))

        {

            IRestRepo _repo = new RestRepo(context);



            var cats = _repo.GetAllRestaurants();



            object p = Assert.Equal(2, Restaurants.Count);

        }

    }
}

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
public class RepoTest : NewBaseType

{ 

private readonly DbContextOptions<Entity.RestaurantdbContext> options; 

 

public RepoTest() 

{ 

options = new DbContextOptionsBuilder<Entity.RestaurantdbContext>().UseSqlite("Filename=Test.db").Options; 

Seed(); 

}

    private string GetDebuggerDisplay()
    {
        return ToString();
    }





 

 