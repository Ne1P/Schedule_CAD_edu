using Microsoft.EntityFrameworkCore;
using ScheduleCad.Data.Interfaces;
using ScheduleCad.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleCad.Data.Repositori
{
    public class ExamsRepositori : iAllExam
    {
        private readonly AppDBContent appDBContent;

        public ExamsRepositori(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Exam> Exam => appDBContent.Exam.Include(c =>c.Group);

        public Exam getObjLes(int examId)=>appDBContent.Exam.FirstOrDefault(p => p.Id == examId);
    }
}
