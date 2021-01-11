using ScheduleCad.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleCad.ViewModels
{
    public class GroupScheduleViewModel
    {
        public IEnumerable<Lesson> getAllles { get; set; }

        public List<string> getAllDay { get; set; }

        public string currGroup { get; set; }

        public int curWeek { get; set; }
    }
}
