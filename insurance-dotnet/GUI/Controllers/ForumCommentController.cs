using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Service.ForumService;
using Data.Models;
namespace GUI.Controllers
{
    public class ForumCommentController : Controller
    {
        ForumCommentService service = new ForumCommentService();
        // GET: ForumComment
        public ActionResult Index()
        {
            return View(service.GetAll());
        }

        // GET: ForumComment/Details/5
        public ActionResult Details(int id)
        {
            return View(service.GetById(id));
        }

        // GET: ForumComment/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ForumComment/Create
        [HttpPost]
        public ActionResult Create( forumcomment p)
        {
           // p.topic_id = topic;
            service.Add(p);
            service.Commit();

            return RedirectToAction("Index");
        }

        // GET: ForumComment/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ForumComment/Edit/5
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

        // GET: ForumComment/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ForumComment/Delete/5
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
