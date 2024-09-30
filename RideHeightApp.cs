using System;

namespace RideHeightApp {
// member variables
class RiderHeight {
    	RiderHeight height = new RiderHeight();

	    Console.WriteLine("How tall are you in centimeters?");
        static void checkHeight(int height)
        {
            if (height < 135) 
            {
                 Console.WriteLine("Sorry! You must be at least 135 cm tall to go on this ride.");
            } 
            else 
            {
                Console.WriteLine("Thank you! Enjoy the ride!");
            }
        }
        static void Main(string[] args) 
        {
            checkHeight(180);
        }

      }

   }
