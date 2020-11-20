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
            return View();
        }

        // GET: Cine/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cine/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

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
            return View();
        }

        // POST: Cine/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
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
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
