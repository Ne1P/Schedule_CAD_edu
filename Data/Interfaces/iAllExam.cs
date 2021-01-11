using ScheduleCad.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleCad.Data.Interfaces
{
    public interface iAllExam
    {
        IEnumerable<Exam> Exam { get; }

        Exam getObjLes(int examId);
    }
}
