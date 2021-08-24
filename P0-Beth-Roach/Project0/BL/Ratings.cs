using System;
using Models;
using DL;

namespace BL
{
    public class Rating
     {
        public static double Ratings(double newRating, double totalRatings, double numberOfRatings)
         {
            
            newRating = Console.ReadLine();
            double rating = 0;
            totalRatings = newRating + rating;
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
    