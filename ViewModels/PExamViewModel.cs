using ScheduleCad.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleCad.ViewModels
{
    public class PExamViewModel
    {
        public List<Exam> getAllExam { get; set; }

        public string currLec { get; set; }
    }
}
