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
            double feverTemp = 0;
            string message = "";

            /*if (tempType == "Celsius" && temperature >= 38)

            { message = $"Your temperature is {temperature}°{tempType[0]}. You appear to have a fever."; }

            if (tempType == "Fahrenheit" && temperature >= 99.5)

            { message = $"Your temperature is {temperature}°{tempType[0]}. You appear to have a fever."; }

            else

            { message = $"Your temperature is {temperature}°{tempType[0]}. You don't have fever."; }

            return message;*/

            if (tempType == "Celsius")
            {
                feverTemp = 38;
            }
            else if (tempType == "Fahrenheit")
            {
                feverTemp = 99.5;
            }
            if (temperature >= feverTemp)
            {
              message = $"Your temperature is {temperature}°{tempType[0]}. You appear to have a fever.";
            }
            else
            {
              message = $"Your temperature is {temperature}°{tempType[0]}. You don't have fever.";
            }


            return message;
            }
        }
}