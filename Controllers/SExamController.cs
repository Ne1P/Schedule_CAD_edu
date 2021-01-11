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
    public class SExamController : Controller
    {
        private readonly iAllGroup _allGroup;
        private readonly iAllExam _allExam;


        public SExamController(iAllGroup iAllGroup, iAllExam iAllExam)
        {
            _allGroup = iAllGroup;
            _allExam = iAllExam;
        }
        [Route("SExam/List/{group}")]
        public ViewResult List(string group)
        {
            string _group = group;
            IEnumerable<Exam> exam = null;
            string currGroup = "";
            if (string.IsNullOrEmpty(group))
            {

            }
            else
            {
                if (string.Equals("kn_304", group, StringComparison.OrdinalIgnoreCase))
                {
                    exam = _allExam.Exam.Where(i => i.Group.Id.Equals(1)).OrderBy(i => i.Id);
                    currGroup = "КН-304";
                    ViewBag.Titel = "Екзамени КН-304";
                }
                else if (string.Equals("kn_305", group, StringComparison.OrdinalIgnoreCase))
                {
                    exam = _allExam.Exam.Where(i => i.Group.Id.Equals(2)).OrderBy(i => i.Id);
                    currGroup = "КН-305";
                    ViewBag.Titel = "Екзамени КН-305";
                }
                else if (string.Equals("kn_306", group, StringComparison.OrdinalIgnoreCase))
                {
                    exam = _allExam.Exam.Where(i => i.Group.Id.Equals(3)).OrderBy(i => i.Id);
                    currGroup = "КН-306";
                    ViewBag.Titel = "Екзамени КН-306";
                }

            }

            IEnumerable<Exam> templ = exam.OrderBy(x => x.DateTime).ToArray();

            var examObj = new SExamViewModel();
            examObj.getAllExam = templ.ToList();
            examObj.currEGroup = currGroup;

            return View(examObj);
        }
    }
}
