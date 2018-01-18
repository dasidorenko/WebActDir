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
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ChangeName(string xyi, string pizda)
        {
            var user = new User()
            {
                name = pizda,
                login = xyi
            };

            return View(user);
        }

        public ActionResult ChangeSurname()
        {
            return View();
        }

        public ActionResult ChangeLogin()
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