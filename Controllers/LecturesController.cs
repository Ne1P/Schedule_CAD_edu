using Microsoft.AspNetCore.Mvc;
using ScheduleCad.Data.Interfaces;
using ScheduleCad.Data.Models;
using ScheduleCad.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleCad.Controllers
{
    public class LecturesController : Controller
    {
        private readonly iAllGroup _allGroup;
        private readonly iAllLessons _allLesson;

        public LecturesController(iAllGroup iAllGroup, iAllLessons iAllLessons)
        {
            _allGroup = iAllGroup;
            _allLesson = iAllLessons;
        }


        [Route ("Lectures/List/{nameLec}")]
        public ViewResult List(string nameLec)
        {
            string _lecName = nameLec;
            IEnumerable<Lesson> lesson = null;
            

            if (string.IsNullOrEmpty(nameLec))
            {

            }
            else if (string.Equals("TomukVV", nameLec, StringComparison.OrdinalIgnoreCase))
            {
                lesson = _allLesson.Lessons.Where(i => i.LecName.Equals("Томюк В.В.")).OrderBy(i => i.Id);
                ViewBag.Titel = "Розклад для Томюк В.В.";
            }
            else if (string.Equals("GolovackiiRI", nameLec, StringComparison.OrdinalIgnoreCase))
            {
                lesson = _allLesson.Lessons.Where(i => i.LecName.Equals("Головацький Р.І.")).OrderBy(i => i.Id);
                ViewBag.Titel = "Розклад для Головацький Р.І.";
            }
            else if (string.Equals("KosobuckiiPC", nameLec, StringComparison.OrdinalIgnoreCase))
            {
                lesson = _allLesson.Lessons.Where(i => i.LecName.Equals("Кособуцький П.С.")).OrderBy(i => i.Id);
                ViewBag.Titel = "Кособуцький П.С.";
            }

            List<string> dayOfWeek = new List<string>() { "Понеділок", "Вівторок", "Середа", "Четвер", "П'ятниця" };

            DateTime nowDataTime = DateTime.Now;
            int firsDayOfYear = (int)new DateTime(nowDataTime.Year, 1, 1).DayOfWeek;
            int weekNumber = (nowDataTime.DayOfYear + firsDayOfYear) / 7;
            weekNumber = weekNumber % 2;
            var scheduleObj = new GroupScheduleViewModel();
            scheduleObj.getAllDay = dayOfWeek;
            scheduleObj.getAllles = lesson;
            scheduleObj.curWeek = weekNumber;

            return View(scheduleObj);

        }
    }
}
