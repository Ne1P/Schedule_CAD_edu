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
    public class GroupsController : Controller
    {
        private readonly iAllGroup _allGroup;
        private readonly iAllLessons _allLesson;

        public GroupsController(iAllGroup iAllGroup, iAllLessons iAllLessons)
        {
            _allGroup = iAllGroup;
            _allLesson = iAllLessons;
        }
        [Route("Groups/List/{group}")]
        public ViewResult List(string group)
        {
            string _group = group;
            IEnumerable<Lesson> lesson = null;
            string currGroup = "";
            if (string.IsNullOrEmpty(group))
            {

            }
            else
            {
                if (string.Equals("kn_304", group, StringComparison.OrdinalIgnoreCase))
                { 
                    lesson = _allLesson.Lessons.Where(i => i.Group.Id.Equals(1)).OrderBy(i => i.Id);
                    currGroup = "КН-304";
                    ViewBag.Titel = "Розклад КН-304";
                }
                else if (string.Equals("kn_305", group, StringComparison.OrdinalIgnoreCase))
                {
                    lesson = _allLesson.Lessons.Where(i => i.Group.Id.Equals(2)).OrderBy(i => i.Id);
                    currGroup = "КН-305";
                    ViewBag.Titel = "Розклад КН-305";
                }
                else if (string.Equals("kn_306", group, StringComparison.OrdinalIgnoreCase))
                {
                    lesson = _allLesson.Lessons.Where(i => i.Group.Id.Equals(3)).OrderBy(i => i.Id);
                    currGroup = "КН-306";
                    ViewBag.Titel = "Розклад КН-306";
                }

            }

             List<string> dayOfWeek = new List<string>() { "Понеділок", "Вівторок", "Середа", "Четвер", "П'ятниця" };

            DateTime nowDataTime = DateTime.Now;
            int firsDayOfYear = (int)new DateTime(nowDataTime.Year, 1, 1).DayOfWeek;
            int weekNumber = (nowDataTime.DayOfYear + firsDayOfYear) / 7;
            weekNumber = weekNumber % 2;
            var scheduleObj = new GroupScheduleViewModel();
                scheduleObj.getAllDay = dayOfWeek;
                scheduleObj.getAllles = lesson;
                scheduleObj.currGroup = currGroup;
                scheduleObj.curWeek = weekNumber;

                return View(scheduleObj);
        }

    }
}
