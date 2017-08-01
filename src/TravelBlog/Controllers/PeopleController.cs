using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TravelBlog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TravelBlog.Controllers
{
    public class PeopleController : Controller
    {
        private TravelBlogContext db = new TravelBlogContext();
        public IActionResult Index()
        {
            return View(db.People.Include(people => people.Experience).ToList());
        }

        public IActionResult Details(int id)
        {
            Person thisPerson = db.People.FirstOrDefault(people => people.PeopleId == id);
            return View(thisPerson);
        }

        public IActionResult Create()
        {
            ViewBag.ExperienceId = new SelectList(db.Experiences, "ExperienceId", "Description");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Person person)
        {
            db.People.Add(person);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            Person thisPerson = db.People.FirstOrDefault(people=> people.PeopleId == id);
            ViewBag.ExperienceId = new SelectList(db.Experiences, "ExperienceId", "Description");
            return View(thisPerson);
        }

        [HttpPost]
        public IActionResult Edit(Person person)
        {
            db.Entry(person).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Person thisPerson = db.People.FirstOrDefault(people => people.PeopleId == id);
            return View(thisPerson);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            Person thisPerson= db.People.FirstOrDefault(people => people.PeopleId == id);
            db.People.Remove(thisPerson);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
