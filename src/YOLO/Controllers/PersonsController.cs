using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using YOLO.Models;
using Microsoft.Data.Entity;
using Microsoft.AspNet.Mvc.Rendering;

namespace YOLO.Controllers
{
    public class PersonsController : Controller
    {
        private YOLODbContext db = new YOLODbContext();
        public IActionResult Index()
        {
            return View(db.Persons.Include(persons => persons.Experience).ToList());
        }

        public IActionResult Details(int id)
        {
            var thisPerson = db.Persons.FirstOrDefault(persons => persons.PersonId == id);
            return View(thisPerson);
        }

        public IActionResult Create()
        {
            ViewBag.ExperienceId = new SelectList(db.Experiences, "ExperienceId", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Person person)
        {
            db.Persons.Add(person);
            db.SaveChanges();
            return RedirectToAction("Index", "Locations");
        }

        public IActionResult Edit(int id)
        {
            var thisPerson = db.Persons.FirstOrDefault(persons => persons.PersonId == id);
            ViewBag.ExperienceId = new SelectList(db.Experiences, "ExperienceId", "Name");
            return View(thisPerson);
        }

        [HttpPost]
        public IActionResult Edit(Person person)
        {
            db.Entry(person).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index", "Locations");
        }

        public IActionResult Delete(int id)
        {
            var thisPerson = db.Persons.FirstOrDefault(persons => persons.PersonId == id);
            return View(thisPerson);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var thisPerson = db.Persons.FirstOrDefault(persons => persons.PersonId == id);
            db.Persons.Remove(thisPerson);
            db.SaveChanges();
            return RedirectToAction("Index", "Locations");
        }
    }
}
