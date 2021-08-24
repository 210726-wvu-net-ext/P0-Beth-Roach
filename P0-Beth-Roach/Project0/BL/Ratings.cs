using System;
using Models;
using DL;

namespace BL
{
    public class Rating
     {
        public static int Ratings(int newRating, int totalRatings, int numberOfRatings)
         {
            
            Console.ReadLine(newRating);
            int rating = 0;
            totalRatings = newRating + rating;
            numberOfRatings = newRating.Count();
            if(newRating>0 && totalRatings>0 && numberOfRatings>0)
            {
               
                var aveRating=((totalRatings + newRating)/numberOfRatings);
            
            }
            else
                throw new ArgumentException("Rating must be a valid number");
         }
    }
} 
    