using Microsoft.AspNetCore.Mvc;
using ScheduleCad.Data.Interfaces;
using ScheduleCad.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleCad.Controllers
{
    public class GroupController : Controller
    {
        private readonly iAllGroup _allGroup;

        public GroupController(iAllGroup iAllGroup)
        {
            _allGroup = iAllGroup;
        }

        [Route("Group/List")]

        public ViewResult List()
        {
            ViewBag.Titel = "Розклад груп";
            GroupListViewModel obj = new GroupListViewModel();
            obj.getAllGroup = _allGroup.allGroup;

            return View(obj);
        }
    }
}
