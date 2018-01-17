using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAD.Models;

namespace WebAD.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            var user = new User()
            {
                login = "Sid"
            };

            return View(user);
        }

        public ActionResult СhangeName()
        {
            return View();
        }

        public ActionResult СhangeSurname()
        {
            return View();
        }

        public ActionResult СhangeLogin()
        {
            return View();
        }

        public ActionResult AddGroupMailBox()
        {
            return View();
        }

        public ActionResult AddUser()
        {
            return View();
        }

        public ActionResult AddUsers()
        {
            return View();
        }
    }
}