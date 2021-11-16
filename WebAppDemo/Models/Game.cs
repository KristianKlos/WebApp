using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcBasics.Models
{
    public class Game
    {
        public static string NumberGuess(int guess, int number)
        {


            if (guess > number)
            {
                return $"{guess} is too high";
            }

            if (guess < number)
            {
                return $"{guess} is too low";
            }


            return "You guessed the correct number";
        }


    }
}