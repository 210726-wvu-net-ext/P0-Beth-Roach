using System;
using Models;
using DL;

namespace BL
{
    public class Rating
     {
        public static double Ratings(double newRating, double totalRatings, double numberOfRatings)
         {
            
            double v2 =newRating;
            v2 = Console.ReadLine("");
            double rating = 0;
            double v1 = totalRatings; 
            v1 = newRating + rating;
            if (newRating>0)
            {
                numberOfRatings++;
            }
            if(newRating>0 && totalRatings>0 && numberOfRatings>0)
            {
               
                var aveRating=((totalRatings + newRating)/numberOfRatings);
            
            }
            else
                throw new ArgumentException("Rating must be a valid number");
         }
    }
} 
    