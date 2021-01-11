using ScheduleCad.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleCad.ViewModels
{
    public class SExamViewModel
    {
        public List<Exam> getAllExam { get; set; }

        public string currEGroup { get; set; }
    }
}
