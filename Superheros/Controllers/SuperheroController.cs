using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Superheros.Models;
using Superheros.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Superheros.Controllers
{
    public class SuperheroController : Controller
    {
        private ApplicationDbContext _context;
        public SuperheroController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: SuperheroController
        public ActionResult Index()
        {
            var super = _context.Superheros;
            return View(super);
        }

        // GET: SuperheroController/Details/5
        public ActionResult Details(int id)
        {
            return View();  
        }

        // GET: SuperheroController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SuperheroController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Superhero superhero)
        {
            try
            {
                _context.Superheros.Add(superhero);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperheroController/Edit/5
        public ActionResult Edit(int id)
        {
            var editting = _context.Superheros.Find(id);
            return View(editting);
        }

        // POST: SuperheroController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Superhero edit)
        {
            try
            {
                _context.Superheros.Update(edit);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperheroController/Delete/5
        public ActionResult Delete(int id)
        {
            var obj = _context.Superheros.Find(id);
            return View(obj);
        }

        // POST: SuperheroController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Superhero removeOne)
        {
            try
            {
               
                _context.Superheros.Remove(removeOne);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
