using Microsoft.AspNetCore.Mvc;
using ScheduleCad.Data.Interfaces;
using ScheduleCad.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleCad.Controllers
{
    public class LectureController : Controller
    {
        private readonly iAllLessons _allLessons;

        public LectureController(iAllLessons iAllLessons)
        {
            _allLessons = iAllLessons;
        }
        [Route("Lecture/List")]
        public ViewResult List()
        {
            List<string> lecName = new List<string>();
            
            foreach(var les in _allLessons.Lessons)
            {
                foreach(var lec in lecName)
                    if (les.LecName != lec)
                        lecName.Add(les.LecName);
            }
            ViewBag.Titel = "Розклад викладачів";
            LectureListViewModel obj = new LectureListViewModel();
            obj.getAllLec = lecName;

            return View(obj);
        }
    }
}
