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
                //this application is written so that individuals can rate restaurants anonymously. 
                Console.WriteLine("Welcome to Restaurant Raters Anonymous!");
                Console.WriteLine("[0] Exit");
                Console.WriteLine("[1] Search for a Restaurant");
                Console.WriteLine("[2] Add a Rating");
                Console.WriteLine("[3] View all Ratings");
                Console.WriteLine("[4] Add a User");
                Console.WriteLine("[5] Admin login");

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

                    case "4":
                        addUser();
                    break;

                    case "5":
                        adminLogin();
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
            double Rating;
            if(selectedRestaurants is not null)
            {
                Console.WriteLine("You selected " + selectedRestaurant.Name);
                
                do
                {
                    Console.WriteLine("Rating from 1 to 5?");
                    Rating = Console.ReadLine();
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
                Console.WriteLine($"{Restaurant.aveRating}");
                Console.WriteLine("-----------------------------------------");
            }
        }

        
        private void SearchRestByName()
         {
            string input;
            Console.WriteLine("Enter the name of the Restaurant to search for: ");
            input = Console.ReadLine();

            Restaurant foundRestaurant = _RestReviewbl.SearchRestByName(input);
            if(foundRestaurant.Name is null)
            {
                Console.WriteLine($"{input} is missing, please try again");
            }
            else {
                Console.WriteLine("We found the Restaurant! {0}", foundRestaurant.Name);
            }
         }
        private void addUser()
        {
            User  addedUser = _useradminbl.addUser(input);
            if(addedUser.userName is null || addedUser.password is null)
                {
                    Console.WriteLine($"You did not enter in a username or password, please try again.");
                }
            else
                {
                    Console.WriteLine($"User {userName} was added! Welcome to the world of restaurant review!");
                }
        }
        
        private void adminLogin()
        {
            bool IsValidLoginforAdmin(string username, string password);
            do
            {
                Console.WriteLine($"Welcome Admin! Select what you want to do:");
                Console.WriteLine("[0] Exit");
                Console.WriteLine("[1] Search for a User");
                Console.WriteLine("[2] View all Users");

                 switch(Console.ReadLine())
                    {
                        case "0":
                            Console.WriteLine("Goodbye!");
                            repeat = false;
                        break;

                        case "1":
                            SearchUsers();
                        break;

                        case "2":
                            ViewAllUsers();
                        break;

                        default:
                            Console.WriteLine("Try again");
                        break;
                    }
            } while(repeat);

        }
        private void SearchUsers()
        {
            string input;
                Console.WriteLine("Enter the name of the User to search for: ");
                input = Console.ReadLine();

                Restaurant foundRestaurant = _RestReviewbl.SearchRestByName(input);
                if(foundRestaurant.Name is null)
                    {
                        Console.WriteLine($"{input} is missing, please try again");
                    }
                else 
                    {
                        Console.WriteLine("We found the Restaurant! {0}", foundRestaurant.Name);
                    }
        }
    }
}