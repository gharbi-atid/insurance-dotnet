using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Service;
using Data.Models;

namespace GUI.Controllers
{
    public class InterviewController : Controller
    {

        InterviewService iss = new InterviewService();


        // GET: Interview
        public ActionResult Index()
        {
            return View(iss.GetAll());
        }

        // GET: Interview/IndexAdmin
        public ActionResult IndexAdmin()
        {
            return View(iss.GetAll().Where( e => e.etat.Equals("Pending")  ) );
        }

        // GET: Interview/Details/5
        public ActionResult Details(int id)
        {
            return View(iss.GetById(id));
        }

        // GET: Interview/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Interview/Create
        [HttpPost]
        public ActionResult Create(Interview i)
        {
            try
            {
                i.etat = "Pending";
                iss.Add(i);
                iss.Commit();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Interview/Edit/5
        public ActionResult Edit(int id)
        {
            Interview inter = iss.GetById(id);

            return View(inter);
        }

        // POST: Interview/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Interview inter)
        {
            Interview x  = iss.GetById(id);
            x.dateInterview = inter.dateInterview;
            x.diplome = inter.diplome;
            x.experience = inter.experience;
            x.motivations = inter.motivations;

            iss.Update(x);
            iss.Commit();
            return RedirectToAction("Index");
        }

        // GET: Interview/Delete/5
        public ActionResult Delete(int id)
        {
            Interview inter = iss.GetById(id);
            return View(inter);
        }

        // POST: Interview/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Interview inter)
        {
            Interview c1 = new Interview();
            c1 = iss.GetById(id);
            iss.Delete(c1);
            iss.Commit();
            return RedirectToAction("Index");
        }

        // GET: Interview/Accept/5
        public ActionResult Accept(int id)
        {
            Interview inter = iss.GetById(id);
            return View(inter);
        }

        // POST: Interview/Accept/5
        [HttpPost]
        public ActionResult Accept(int id, Interview inter)
        {
            Interview c1 = new Interview();
            c1 = iss.GetById(id);
            c1.etat = "Accepted";
            iss.Update(c1);
            iss.Commit();
            return RedirectToAction("IndexAdmin");
        }



        // GET: Interview/Reject/5
        public ActionResult Reject(int id)
        {
            Interview inter = iss.GetById(id);
            return View(inter);
        }

        // POST: Interview/Accept/5
        [HttpPost]
        public ActionResult Reject(int id, Interview inter)
        {
            Interview c1 = new Interview();
            c1 = iss.GetById(id);
            c1.etat = "Rejected";
            iss.Update(c1);
            iss.Commit();
            return RedirectToAction("IndexAdmin");
        }

    }
}
