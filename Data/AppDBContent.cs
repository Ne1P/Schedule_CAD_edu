using Microsoft.EntityFrameworkCore;
using ScheduleCad.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleCad.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options): base(options)
        {

        }
        public DbSet<Group> Group { get; set; }

        public DbSet<Lesson> Lesson { get; set; }

        public DbSet<Exam> Exam { get; set; }

       
        
        
    }
}
