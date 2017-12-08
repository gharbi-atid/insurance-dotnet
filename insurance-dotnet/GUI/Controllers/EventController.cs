using Data.Models;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GUI.Controllers
{
    public class EventController : Controller
    {
        EventService ES = new EventService();
        // GET: Event
        public ActionResult Index()
        {
            return View(ES.GetAll());
        }

        // GET: Event/Details/5
        public ActionResult Details(int id)
        {
            return View(ES.GetById(id));
        }

        // GET: Event/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Event/Create
        [HttpPost]
        public ActionResult Create(evenement E)
        {
            try
            {
                ES.Add(E);
                ES.Commit();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Event/Edit/5
        public ActionResult Edit(int id)
        {
            evenement Eve = ES.GetById(id);

            return View(Eve);
        }

        // POST: Event/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, evenement EV)
        {
            evenement E = ES.GetById(id);
            E.DateDebut = EV.DateDebut;
            E.DateDebut = EV.DateFin;
            E.price = EV.price;
            E.name = EV.name;
            E.places = EV.places;

            ES.Update(E);
            ES.Commit();
            return RedirectToAction("Index");
        }

        // GET: Event/Delete/5
        public ActionResult Delete(int id)
        {
            evenement Eve = ES.GetById(id);
            return View(Eve);
        }

        // POST: Event/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, evenement Eve)
        {
            evenement E = new evenement();
            E = ES.GetById(id);
            ES.Delete(E);
            ES.Commit();
            return RedirectToAction("Index");


        }
    }
}
