using ScheduleCad.Data.Interfaces;
using ScheduleCad.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleCad.Data.Repositori
{
    public class GroupsRepositori : iAllGroup
    {
        private readonly AppDBContent appDBContent;

        public GroupsRepositori(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Group> allGroup => appDBContent.Group;
    }
}
