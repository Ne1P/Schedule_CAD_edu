using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleCad.Data.Models
{
    public class Group
    {
        public int Id { set; get; }

        public string GroupName { set; get; }
        
        public List<Lesson> Lessons { set; get; }

        public List<Exam> Exams { set; get; }
    }
}
