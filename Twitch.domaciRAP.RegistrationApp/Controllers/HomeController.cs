using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Twitch.domaciRAP.RegistrationApp.Models;

namespace Twitch.domaciRAP.RegistrationApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //creating first Events object and adding values
            Events _eventOne = new Events();

            //Accessing properties and assigning values to it
            _eventOne.Id = 1;
            _eventOne.Name = "Intruduction to web development";
            _eventOne.Descirption = "This will cover session about HTML & CSS.";
            _eventOne.StardDateTime = new DateTime(2021, 12, 27, 9, 0, 0);
            _eventOne.CreatedBy = "Jasmin Becirevic";
            _eventOne.CreatedByEmail = "jasmin_becirevic@hotmail.com";
            _eventOne.Presneter = "Fireman Sam";
            _eventOne.PresenterEmail = "jasmin_becirevic@hotmail.com";
            _eventOne.AmountOfAttendees = 5;
            _eventOne.IsActive = true;

            //creating second Events object and adding values
            Events _eventTwo = new Events();

            //create a second event and assigne value to it
            _eventTwo.Id = 2;
            _eventTwo.Name = "Intruduction to JavaScript";
            _eventTwo.Descirption = "This will cover JavaScript tips and tricks";
            _eventTwo.StardDateTime = new DateTime(2021, 12, 28, 9, 0, 0);
            _eventTwo.CreatedBy = "Jasmin Becirevic";
            _eventTwo.CreatedByEmail = "jasmin_becirevic@hotmail.com";
            _eventTwo.Presneter = "domaciRAP";
            _eventTwo.PresenterEmail = "jasmin_becirevic@hotmail.com";
            _eventTwo.AmountOfAttendees = 10;
            _eventTwo.IsActive = true;

            //creating 3rd Events object and adding values
            Events _eventThree = new Events();

            //create a second event and assigne value to it
            _eventThree.Id = 3;
            _eventThree.Name = "Intruduction to  C#";
            _eventThree.Descirption = "This will cover C# tips and tricks";
            _eventThree.StardDateTime = new DateTime(2021, 12, 29, 9, 0, 0);
            _eventThree.CreatedBy = "Jasmin Becirevic";
            _eventThree.CreatedByEmail = "jasmin_becirevic@hotmail.com";
            _eventThree.Presneter = "domaciRAP";
            _eventThree.PresenterEmail = "jasmin_becirevic@hotmail.com";
            _eventThree.AmountOfAttendees = 100;
            _eventThree.IsActive = true;

            //creating 4th Events object and adding values
            Events _eventFourth = new Events();

            //create a second event and assigne value to it
            _eventFourth.Id = 4;
            _eventFourth.Name = "Intrudction to Database";
            _eventFourth.Descirption = "This will cover Database tips and tricks";
            _eventFourth.StardDateTime = new DateTime(2021, 12, 30, 9, 0, 0);
            _eventFourth.CreatedBy = "Jasmin Becirevic";
            _eventFourth.CreatedByEmail = "jasmin_becirevic@hotmail.com";
            _eventFourth.Presneter = "domaciRAP";
            _eventFourth.PresenterEmail = "jasmin_becirevic@hotmail.com";
            _eventFourth.AmountOfAttendees = 100;
            _eventFourth.IsActive = true;


            //create a list of Events and add the variabls _eventOne & _eventTwo
            List<Events> _eventsList = new List<Events>();
            _eventsList.Add(_eventOne);
            _eventsList.Add(_eventTwo);
            _eventsList.Add(_eventThree);
            _eventsList.Add(_eventFourth);

            return View(_eventsList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
