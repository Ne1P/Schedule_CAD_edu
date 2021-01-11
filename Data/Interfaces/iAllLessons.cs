using ScheduleCad.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleCad.Data.Interfaces
{
    public interface iAllLessons
    {
        IEnumerable<Lesson> Lessons { get; }

        Lesson getObjLes(int lesId);
    }
}
