using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MvcBasics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcBasics.Controllers
{
    public class GameController : Controller
    {
        [HttpGet]
        public IActionResult GuessingGame()
        {
            Random random = new Random();
            HttpContext.Session.SetInt32("Number", random.Next(1, 1));

            CookieOptions option = new CookieOptions();
            option.Expires = DateTime.Now.AddHours(1);
            Response.Cookies.Append("CountGuesses", "0", option);
            return View();
        }
        [HttpPost]
        public IActionResult GuessingGame(int guess)
        {
            string message = "";
            int nrOfGuesses = 0;

            if (guess > 0 || guess <= 100)
            {

                if (!HttpContext.Session.IsAvailable)

                { return RedirectToAction(nameof(GuessingGame)); }

                int number = (int)HttpContext.Session.GetInt32("Number");
                if (!string.IsNullOrWhiteSpace(number.ToString()))

                {
                    if (Request.Cookies.ContainsKey("CountGuesses"))
                    {
                        string GuessesStored = Request.Cookies["CountGuesses"];
                        nrOfGuesses = Int32.Parse(GuessesStored) + 1;
                        if (Request.Cookies["CountGuesses"] != null)

                        { ViewBag.guessesCookie = GuessesStored; }
                    }
                    message = Game.NumberGuess(guess, number);
                }

                else { return RedirectToAction(nameof(GuessingGame)); }
            }

            else { message = "Enter a number beween 1-100!"; }

            if (!string.IsNullOrWhiteSpace(nrOfGuesses.ToString()))
            {
                CookieOptions option = new CookieOptions();
                option.Expires = DateTime.Now.AddMinutes(10);
                Response.Cookies.Append("CountGuesses", nrOfGuesses.ToString(), option);
            }

            ViewBag.guess = guess;
            ViewBag.nrOfGuesses = nrOfGuesses;
            ViewBag.msg = message;

            if (message.Contains("correct")) { return View("WinScreen"); }

            else { return View(); }

        }
    }
}