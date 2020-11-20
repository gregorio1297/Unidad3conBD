using PracticaBD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticaBD.Controllers
{
    public class CineController : Controller
    {
        readonly CinebdConnection db = new CinebdConnection();
        // GET: Cine
        public ActionResult Index()
        {
            var horas = db.Cines.ToList();
            //select * from Cine
            return View(horas);
        }

        // GET: Cine/Details/5
        public ActionResult Details(int id)
        {
            var ho = db.Cines.Find(id);
            return View(ho);
        }

        // GET: Cine/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cine/Create
        [HttpPost]
        public ActionResult Create(Cine c)
        {
            try
            {
                // TODO: Add insert logic here
                db.Cines.Add(c);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cine/Edit/5
        public ActionResult Edit(int id)
        {
            var horario = db.Cines.Find(id);
            return View(horario);
        }

        // POST: Cine/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Cine c)
        {
            try
            {
                var hor = db.Cines.Find(id);

                
                hor.Hora = c.Hora;
                db.SaveChanges();
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cine/Delete/5
        public ActionResult Delete(int id)
        {
            var hora = db.Cines.Find(id);
            return View(hora);
        }

        // POST: Cine/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Cine c)
        {
            try
            {
                // TODO: Add delete logic here
                var horar = db.Cines.Find(id);
                db.Cines.Remove(horar);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
