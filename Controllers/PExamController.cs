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
    public class PExamController: Controller
    {
        private readonly iAllGroup _allGroup;
        private readonly iAllExam _allExam;

        public PExamController(iAllGroup iAllGroup, iAllExam iAllExam)
        {
            _allGroup = iAllGroup;
            _allExam = iAllExam;
        }


        [Route("PExam/List/{nameLec}")]
        public ViewResult List(string nameLec)
        {
            string _lecName = nameLec;
            IEnumerable<Exam> exam = null;
            string currLec = "";

            if (string.IsNullOrEmpty(nameLec))
            {

            }
            else if (string.Equals("IvancivRD", nameLec, StringComparison.OrdinalIgnoreCase))
            {
                exam = _allExam.Exam.Where(i => i.LecName.Equals("Іванців Р.Д.")).OrderBy(i => i.Id);
                ViewBag.Titel = "Розклад для Іванців Р.Д.";
                currLec = "Іванців Р.Д.";
            }
            else if (string.Equals("KolesnikKK", nameLec, StringComparison.OrdinalIgnoreCase))
            {
                exam = _allExam.Exam.Where(i => i.LecName.Equals("Колесник К.К.")).OrderBy(i => i.Id);
                ViewBag.Titel = "Розклад для Колесник К.К.";
                currLec = "Колесник К.К.";
            }
            else if (string.Equals("KosobuckiiPC", nameLec, StringComparison.OrdinalIgnoreCase))
            {
                exam = _allExam.Exam.Where(i => i.LecName.Equals("Кособуцький П.С.")).OrderBy(i => i.Id);
                ViewBag.Titel = "Розклад для Кособуцький П.С.";
                currLec = "Кособуцький П.С.";
            }

            IEnumerable<Exam> templ = exam.OrderBy(x => x.DateTime).ToArray();

            var pexamObj = new PExamViewModel();
            pexamObj.getAllExam = templ.ToList();
            pexamObj.currLec = currLec;
            return View(pexamObj);

        }
    }
}
