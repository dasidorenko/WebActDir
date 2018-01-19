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
            return View();
        }
        
        public ActionResult ChangeName()
        {
            return View();
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

        [HttpGet]
        public ActionResult AddUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddUser(string name, string surname, string login, string password)
        {
            
            return View();
        }

        public ActionResult AddUsers()
        {
            return View();
        }
    }
}