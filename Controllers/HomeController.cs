using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleCad.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]

        public ViewResult Index()
        {

            ViewBag.Titel = "Розклад кафедри САПР";


            return View();
           

        }
    }
}
