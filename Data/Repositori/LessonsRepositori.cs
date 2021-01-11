using Microsoft.EntityFrameworkCore;
using ScheduleCad.Data.Interfaces;
using ScheduleCad.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleCad.Data.Repositori
{
    public class LessonsRepositori : iAllLessons
    {
        private readonly AppDBContent appDBContent;

        public LessonsRepositori(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Lesson> Lessons => appDBContent.Lesson.Include(c => c.Group);


        public Lesson getObjLes(int lesId) => appDBContent.Lesson.FirstOrDefault(p => p.Id == lesId);
    }
}
