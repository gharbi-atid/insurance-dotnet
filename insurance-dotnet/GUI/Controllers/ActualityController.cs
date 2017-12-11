using Data.Models;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GUI.Controllers
{
    public class ActualityController : Controller
    {

        ActualiteService iss = new ActualiteService();

        // GET: Actuality
        public ActionResult Index()
        {
            return View(iss.GetAll());
        }

        // GET: Actuality/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Actuality/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Actuality/Create
        [HttpPost]
        public ActionResult Create(actuality i)
        {
            try
            {
                // TODO: Add insert logic here
                
                iss.Add(i);            
                iss.Commit();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Actuality/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Actuality/Edit/5
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

        // GET: Actuality/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Actuality/Delete/5
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
