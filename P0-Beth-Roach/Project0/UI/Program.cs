using UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using DL.Entities;
using BL;
using DL;
using System.IO;

var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .Build();

string connectionString = configuration.GetConnectionString("Restauranttdb");

DbContextOptions<RestaurantdbContext> options = new DbContextOptionsBuilder<RestaurantdbContext>()
    .UseSqlServer(connectionString)
    .Options;

var context = new RestaurantdbContext(options);


IMenu menu = new MainMenu(new RestReview(new RestRepo(context)));
menu.Start();