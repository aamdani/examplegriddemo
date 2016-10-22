using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using EditableGridExample.Models;

namespace EditableGridExample.Controllers
{
    [Authorize]
    public class EventsController : Controller
    {
        private developContext _context;

        public EventsController(developContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var model = _context.Event.ToList() ?? new List<Event>();
            return View(model);
        }


        public IActionResult Error()
        {
            return View();
        }
    }
}
