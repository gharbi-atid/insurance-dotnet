using Domain;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GUI.Controllers
{
    public class TugController : Controller
    {
        TugService tugService = new TugService();
        // GET: Tug
        public ActionResult Index()
        {
            return View(tugService.GetAll());
        }

        // GET: Tug/Details/5
        public ActionResult Details(int id)
        {
            return View(tugService.GetById(id));
        }

        // GET: Tug/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tug/Create
        [HttpPost]
        public ActionResult Create(Tug tug)
        {
            try
            {
                tugService.Add(tug);
                tugService.Commit();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Tug/Edit/5
        public ActionResult Edit(int id)
        {
            return View(tugService.GetById(id));
        }

        // POST: Tug/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Tug tug)
        {
            try
            {
                Tug tug1 = new Tug();
                tug1 = tugService.GetById(id);
                tug1.idCar = tug.idCar;
                tug1.idTug = tug.idTug;
                tug1.price = tug.price;
                tug1.reference = tug.reference;
                tug1.startDate = tug.startDate;
                tug1.endDate = tug.endDate;
                tug1.status = tug.status;
                tug1.type = tug.type;

                tugService.Update(tug1);
                tugService.Commit();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Tug/Delete/5
        public ActionResult Delete(int id)
        {
            return View(tugService.GetById(id));
        }

        // POST: Tug/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Tug tug)
        {
            try
            {
                Tug tug1 = new Tug();
                tug1 = tugService.GetById(id);
                tugService.Delete(tug1);
                tugService.Commit();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
