using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TravelBlog.Models;
using Microsoft.EntityFrameworkCore;

namespace TravelBlog.Controllers
{
    public class LocationsController : Controller
    {
        private TravelBlogContext db = new TravelBlogContext();
        public IActionResult Index()
        {
            return View(db.Locations.ToList());
        }
        public IActionResult Details(int id)
        {
            var thisLocation = db.Locations.Include(locations => locations.Experiences).ThenInclude(experiences => experiences.People).FirstOrDefault(location => location.LocationId == id);
            //var thisExperience = from p in db.People
            //                    join e in db.Experiences on p.ExperienceId equals e.ExperienceId
            //                    join l in db.Locations on e.LocationId equals l.LocationId
            //                    where l.LocationId == id
            //                    select new { p };
            return View(thisLocation);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Location location)
        {
            db.Locations.Add(location);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var thisLocation = db.Locations.FirstOrDefault(locations => locations.LocationId == id);
            return View(thisLocation);
        }
        [HttpPost]
        public IActionResult Edit(Location location)
        {
            db.Entry(location).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var thisLocation = db.Locations.FirstOrDefault(locations => locations.LocationId == id);
            return View(thisLocation);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var thisLocation = db.Locations.FirstOrDefault(locations => locations.LocationId == id);
            db.Locations.Remove(thisLocation);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
