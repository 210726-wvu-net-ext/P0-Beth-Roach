using Models;
using BL;
using System;
using System.Collections.Generic;
using Serilog;

namespace UI
{
    public class MainMenu : IMenu
    {
        
        private IRestaurantBL _restaurantbl;
        public MainMenu(IRestaurantBL bl)
        {
            _restaurantbl = bl;
            Log.Logger=new LoggerConfiguration()
                            .MinimumLevel.Debug()
                            .WriteTo.Console()
                            .WriteTo.File("../logs/restaurantlogs.txt", rollingInterval:RollingInterval.Day)
                            .CreateLogger();
            Log.Information("UI begining");
        }

        public void Start()
        {
            bool repeat = true;
            do
            {
                Console.WriteLine("Welcome to Restaurant Rater!");
                Console.WriteLine("[0] Exit");
                Console.WriteLine("[1] Search for a Restaurant");
                Console.WriteLine("[2] Add a Rating");
                Console.WriteLine("[3] View all Ratings");
                

                switch(Console.ReadLine())
                {
                    case "0":
                        Console.WriteLine("Goodbye!");
                        repeat = false;
                    break;

                    case "1":
                        SearchRestaurants();
                    break;

                    case "2":
                        AddaRating();
                    break;

                    case "3":
                        ViewAllRestaurants();
                    break;


                    default:
                        Console.WriteLine("Try again");
                    break;
                }
            } while(repeat);
        }

        private void SearchRestaurants() 
        {
            string input;
            Restaurant searchRestaurants;

            Console.WriteLine("Enter Restaurant Name");
            
            do
            {
                Console.WriteLine("Name: ");
                input = Console.ReadLine();

            } while(String.IsNullOrWhiteSpace(input));


          
        }
        private void AddaRating() 
        {
            List<Restaurants> restaurants = _RestReviewbl.ViewAllRestaurants();
            string prompt = "Select a Restaurant to rate";
            restaurants selected = SelectARestaurant(restaurants, prompt);
            string Rating;
            if(selectedRestaurants is not null)
            {
                Console.WriteLine("You selected " + selectedRestaurant.Name);
                
                do
                {
                    Console.WriteLine("Rating from 1 to 5?");
                    foodType = Console.ReadLine();
                } while(String.IsNullOrWhiteSpace(Rating));

                Rating addedRating = new Rating(selectedRestaurant.Id, Rating);

                try
                {
                    updatedRating = _Ratingsbl.Rating(Rating);
                   
                    Log.Debug("Your Rating has been added ");
                }
                catch (Exception ex)
                {
                    Log.Error(ex, "Please enter a valid rating.");
                    //Console.WriteLine(ex);
                }
                finally{
                    Log.CloseAndFlush();
                }
            }
        }

        private void ViewAllRestaurants() 
        {
            List<Restaurant> restaurants = _RestReviewbl.ViewAllRestaurants();
            foreach(Restaurant restaurant in restaurants)
            {
                var rating= Ratings.Rating(restaurant.rating);
                Console.WriteLine($"{Restaurant.Name}");
                Console.WriteLine($"{Restaurant.Cost}");
                Console.WriteLine($"{Restaurant.TypeofFood}");
                Console.WriteLine($"{Restaurant.rating}");
                Console.WriteLine("-----------------------------------------");
            }
        }

        
        private void SearchCatByName()
        {
            string input;
            Console.WriteLine("Enter the name of the Restaurant to search: ");
            input = Console.ReadLine();

            Restaurant foundRestaurant = _RestReviewbl.SearchRestaurantByName(input);
            if(foundRestaurant.Name is null)
            {
                Console.WriteLine($"{input} is missing, please return them asap :'(");
            }
            else {
                Console.WriteLine("We found the Restaurant! {0}", foundRestaurant.Name);
            }
        }
    }
}