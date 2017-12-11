using Data.Models;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GUI.Controllers
{
    public class RendezvousController : Controller
    {
        RendezvousService rs = new RendezvousService();

        // GET: Rendezvous
        public ActionResult Index()
        {
            return View(rs.GetAll());
        }

        // GET: Rendezvous/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Rendezvous/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Rendezvous/Create
        [HttpPost]
        public ActionResult Create(Rendezvous r)
        {
            try
            {
                rs.Add(r);
                rs.Commit();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Rendezvous/Edit/5
        public ActionResult Edit(int id)
        {
            Rendezvous r = rs.GetById(id);
            return View(r);
        }

        // POST: Rendezvous/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Rendezvous r)
        {
            try
            {
                Rendezvous x = rs.GetById(id);
                x.Description = r.Description;
                x.DateRendezVous = r.DateRendezVous;
                x.NomAssurance = r.NomAssurance;
                x.oks = r.oks;
                x.Insured_cin = r.Insured_cin;

                rs.Update(x);
                rs.Commit();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Rendezvous/Delete/5
        public ActionResult Delete(int id)
        {
            Rendezvous r = rs.GetById(id);
            return View(r);
        }

        // POST: Rendezvous/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Rendezvous r)
        {
            try
            {
                Rendezvous c1 = new Rendezvous();
                c1 = rs.GetById(id);
                rs.Delete(c1);
                rs.Commit();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
