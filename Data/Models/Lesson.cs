using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleCad.Data.Models
{
    public class Lesson
    {
        public int Id { set; get; }

        public int Day { set; get; }

        public int LesNum { set; get; }

        public string LesName { set; get; }

        public string LecName { set; get; }

        public string Room { set; get; }

        public string Build { set; get; }

        public string LesType { set; get; }

        public bool AllGroup { set; get; }

        public int NumSubGroup { set; get; }

        public bool AllTime { set; get; }

        public int TimeSet { set; get; }

        public virtual Group Group { set; get; }

    }
}
