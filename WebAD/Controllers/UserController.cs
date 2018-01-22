using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAD.Models;
using System.DirectoryServices;

namespace WebAD.Controllers
{
    public class UserController : Controller
    {
        private const string domainPath = "OU=TEST, OU=Факультеты, DC=main, DC=sgu, DC=ru";
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
        public ActionResult AddUser(string userFirstName, string userSecondName, string userLogin, string userPassword)
        {
            string connectionPrefix = "LDAP://" + domainPath;
            DirectoryEntry dirEntry = new DirectoryEntry(connectionPrefix);
            DirectoryEntry newUser = dirEntry.Children.Add("CN=" + userLogin, "user");
            newUser.Properties["samAccountName"].Add(userLogin);
            newUser.Properties["givenName"].Add(userFirstName);
            newUser.Properties["sn"].Add(userSecondName);
            newUser.CommitChanges();

            newUser.Invoke("SetPassword", new object[] { userPassword });
            newUser.CommitChanges();

            EnableUser(newUser);
            dirEntry.Close();
            newUser.Close();
            return View();
        }

        public void EnableUser(DirectoryEntry user) 
        {
            int old_UAC = (int)user.Properties["userAccountControl"].Value;
            int ADS_UF_ACCOUNTDISABLE = 2;
            user.Properties["userAccountControl"][0] = (old_UAC & ~ADS_UF_ACCOUNTDISABLE);
            user.CommitChanges();
        }

        public void unlockAccount(DirectoryEntry user)
        {
            user.Properties["LockOutTime"].Value = 0; //unlock account
            user.CommitChanges();
            user.Close();
        }

        public void ResetPassword(DirectoryEntry user, string newPassword)
        {
            user.Invoke("SetPassword", new object[] { newPassword });
            user.Properties["LockOutTime"].Value = 0; //unlock account
            user.CommitChanges();
            user.Close();
        }

        public ActionResult AddUsers()
        {
            return View();
        }
    }
}