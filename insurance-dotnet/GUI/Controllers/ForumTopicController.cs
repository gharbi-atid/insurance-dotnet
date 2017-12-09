using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Service.ForumService;
using Data.Models;
namespace GUI.Controllers
{
    public class ForumTopicController : Controller
    {
        ForumTopicService service= new ForumTopicService();
        // GET: ForumTopic
        public ActionResult Index()
        {
            return View(service.GetAll());
        }

        // GET: ForumTopic/Details/5
        public ActionResult Details(int id)
        {
            return View(service.GetById(id));
        }

        // GET: ForumTopic/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ForumTopic/Create
        [HttpPost]
        public ActionResult Create(forumtopic p)
        {
            try
            {
                service.Add(p);
                service.Commit();
                return View();

            }
            catch
            {
                return View();
            }
        }

        // GET: ForumTopic/Edit/5
        public ActionResult Edit(int id)
        {
            forumtopic ft = service.GetById(id);

            return View(ft);
        }

        // POST: ForumTopic/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, forumtopic topic)
        {
            forumtopic ft = service.GetById(id);
            ft.description = topic.description;
            ft.id = topic.id;
            ft.image = topic.image;
            ft.nbVue = topic.nbVue;
            ft.title = topic.title;
          
            service.Update(ft);
            service.Commit();
            return RedirectToAction("Index");
        }

        // GET: ForumTopic/Delete/5
        public ActionResult Delete(int id)
        {
            forumtopic ft = service.GetById(id);
            return View(ft);
        }

        // POST: ForumTopic/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, forumtopic topic)
        {
            forumtopic ft = service.GetById(id);
            ft.description = topic.description;
            ft.id = topic.id;
            ft.image = topic.image;
            ft.nbVue = topic.nbVue;
            ft.title = topic.title;
            service.Delete(ft);
            service.Commit();
            return RedirectToAction("Index");
        }
    }
}
