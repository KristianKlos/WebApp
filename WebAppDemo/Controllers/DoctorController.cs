using Microsoft.AspNetCore.Mvc;
using MvcBasics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDemo.Controllers
{
    public class DoctorController : Controller
    {
        [HttpGet]
        public IActionResult FeverCheck()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FeverCheck(float temperature, string tempType)
        {
            string message = "";
            message = Doctor.FeverCheck(temperature, tempType);
            ViewBag.temp = temperature;
            ViewBag.type = tempType;
            ViewBag.message = message;
            return View("FeverResult");
        }
    }
}
