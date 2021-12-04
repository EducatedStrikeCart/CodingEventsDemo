using Microsoft.AspNetCore.Mvc;
using CodingEventsDemo.Models;
using CodingEventsDemo.Data;
using System.Collections.Generic;
using System.Linq;
using CodingEventsDemo.ViewModels;

namespace CodingEventsDemo.Controllers
{
    public class EventCategoryController : Controller
    {
        private EventDbContext context;

        public EventCategoryController(EventDbContext dbContext)
        {
            context = dbContext;
        }
        public IActionResult Index()

        {
            List<EventCategory> eventCategories = context.EventsCategory.ToList();

            return View(eventCategories);
        }


        public IActionResult Create(AddEventCategoryViewModel addEventCategoryViewModel)
        {

            return View(addEventCategoryViewModel);
        }

        [HttpPost]
        [Route("EventCategory/Create")]
        public IActionResult ProcessCreateEventCategoryForm(AddEventCategoryViewModel addEventCategoryViewModel)
        {
            //if (ModelState.IsValid)
            //{
                EventCategory newEventCategory = new EventCategory
                {
                    Name = addEventCategoryViewModel.Name
                };
                context.EventsCategory.Add(newEventCategory);
                context.SaveChanges();
                return Redirect("/EventCategory");
            //}

            //return View("Create", addEventCategoryViewModel);
        }
    }
}
