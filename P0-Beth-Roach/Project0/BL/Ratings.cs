using System;
using Models;
using DL;

namespace BL
{
    public class Rating
     {
        public static double Ratings(double newRating, double totalRatings, double numberOfRatings)
         {
            
            Console.ReadLine(newRating);
            double rating = 0;
            totalRatings = newRating + rating;
            numberOfRatings = newRating.Count;
            if(newRating>0 && totalRatings>0 && numberOfRatings>0)
            {
               
                var aveRating=((totalRatings + newRating)/numberOfRatings);
            
            }
            else
                throw new ArgumentException("Rating must be a valid number");
         }
    }
} 
    