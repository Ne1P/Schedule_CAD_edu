using ScheduleCad.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleCad.ViewModels
{
    public class GroupListViewModel
    {
        public IEnumerable<Group> getAllGroup { get; set; }
    }
}
