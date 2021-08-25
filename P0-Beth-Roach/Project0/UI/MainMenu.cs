using Models;
using BL;
using DL;
using System;
using System.Collections.Generic;
using Serilog;

namespace UI
{
    public class MainMenu : IMenu
    {
        
        private IRestReview _RestReview;
        public MainMenu(IRestReview restReview)
        {
            _RestReview = restReview;
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
                        addAReview();
                    break;

                    case "3":
                        ViewAllRestaurants();
                    break;

                    case "4":
                        addUserLogin();
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
        private void addAReview() 
        {
            List<Restaurant> restaurants = _RestReview.ViewAllRestaurants();
            string prompt = "Select a Restaurant to Review";
            string name = Console.ReadLine();
            string review;
            if(name is not null)
            {
                Console.WriteLine("You selected {Name}");
                
                do
                {
                    Console.WriteLine("Please enter a review");
                    review = Console.ReadLine();
                } while(String.IsNullOrWhiteSpace(review));

               /* try
                {
                    review = _RestReview.review();
                   
                    Log.Debug("Your Review has been added ");
                }
                catch (Exception ex)
                {
                    Log.Error(ex, "Please enter a valid review.");
                    //Console.WriteLine(ex);
                }
                finally{
                    Log.CloseAndFlush();
                }*/
            }
        }

        private void ViewAllRestaurants() 
        {
            List<Restaurant> restaurants = _RestReview.ViewAllRestaurants();
            foreach(Restaurant restaurant in restaurants)
            {
                Console.WriteLine($"{restaurant.Name}");
                
            }
        }

        
        private void SearchRestByName()
         {
            string input;
            Console.WriteLine("Enter the name of the Restaurant to search for: ");
            input = Console.ReadLine();

            Restaurant foundRestaurant = _RestReview.SearchRestByName(input);
            if(foundRestaurant.Name is null)
            {
                Console.WriteLine($"{input} is missing, please try again");
            }
            else {
                Console.WriteLine("We found the Restaurant! {0}", foundRestaurant.Name);
            }
         }
        private void addUserLogin()
        {
            string userName = "0";
            string pw;
            user newUser;
            do
            {
            Console.WriteLine($"Enter new Username: ");
            string uname = Console.ReadLine();
            Console.WriteLine($"Enter a password: ");
            string PW = Console.ReadLine();
            Console.WriteLine($"Username is {uname} and password is {PW}");
            }while(String.IsNullOrWhiteSpace(userName));
            newUser = new user();
            newUser = _RestReview.addUserLogin();
        }
        
        public void adminLogin()
        {
            bool repeat = true;
            string username, password;
            Console.WriteLine($"Enter username and Password");
            Console.WriteLine("UserName: ");
            username = Console.ReadLine();
            Console.WriteLine("Password: ");
            password = Console.ReadLine();
            admin adminUser = new admin();
            bool isValid = adminUser.Adminlogin(username, password);
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
            }while(repeat);

        }
        private void ViewAllUsers() 
        {
            List<user> allUser = _useradmin.ViewAllUsers();
            foreach(Users u in ViewAllUsers)
            {
                Console.WriteLine($"{u.userName} {u.Password}");

                Console.WriteLine("-----------------------------------------");
            }
        }
        private void SearchUsers()
        {
            string input;
                Console.WriteLine("Enter the name of the User to search for: ");
                input = Console.ReadLine();

                Restaurant foundRestaurant = _RestReview.SearchRestByName(input);
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