using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleCad.Controllers
{
    public class ExplanController: Controller
    {
        [Route("Explan/List")]
        public ViewResult List()
        {
            ViewBag.Titel = "Пояснення до розкладу";
            return View();
        }
    }
}
