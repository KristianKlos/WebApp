using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcBasics.Models
{
    public class Doctor
    {
        public static string FeverCheck(float temperature, string tempType)
        {

            string message = "";

            if (tempType == "Celsius")
            {
                if (temperature >= 38)
                    {message = $"Your temperature is {temperature}. You appear to have a fever.";}
                else
                    {message = $"Your temperature is {temperature}. You don't have fever.";}

            }

            else if (tempType == "Fahrenheit")
            {
                if (temperature >= 99.5)
                    {message = $"Your temperature is { temperature }. You appear to have a fever.";}
                else
                    {message = $"Your temperature is { temperature }. You don't have fever.";}
            }

            return message;

        }
    }
}