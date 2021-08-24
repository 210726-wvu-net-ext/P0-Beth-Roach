using Xunit;

using Microsoft.EntityFrameworkCore;

using Entity = RestaurantDL.Entities;

using Models;

using RestaurantDL;
using System.Diagnostics;



//install Microsoft.EntityFrameworkCore.Sqlite for mocking db 

namespace RestaurantTest;

//[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
public class RepoTest : NewBaseType

{ 

private readonly DbContextOptions<Entity.RestaurantdbContext> options; 

 

public RepoTest() 

{ 

options = new DbContextOptionsBuilder<Entity.RestaurantdbContext>().UseSqlite("Filename=Test.db").Options; 

Seed(); 

}

    private string GetDebuggerDisplay() => ToString();
}





 