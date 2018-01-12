using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data.Models;
using ServiceStack;
using Service;
namespace GUI.Controllers
{
    public class HomeController : Controller
    {
        UserService us = new UserService();   
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(user x)
        {
            user a = us.authentification(x.login, x.password);



            if (a == null) {
                return View();
            }
            else if (a.role.Equals("admin"))
            {

                Session["user"] = a;
                return Redirect("~/Interview/IndexAdmin");
            }
            else
            {
                Session["user"] = a;
                return Redirect("~/Interview");
            }


        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}