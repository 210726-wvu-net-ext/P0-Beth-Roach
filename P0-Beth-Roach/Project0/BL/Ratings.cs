using System;
//using DL;

namespace BL
{
         
    public static double Rating(double newRating, double totalRatings, double numberOfRatings)
    {
            
            Console.Readline(newRating);
            int rating = 0;
            totalRatings = newRating + rating;
            numberOfRatings = count.newRating;
            if(newRating>0 && totalRatings>0 && numberOfRatings>0)
            {
               
                var aveRating=((totalRatings + newRating)/numberOfRatings);
            
            }
            else
                throw new ArgumentException("Rating must be a valid number");
    }
} 
    