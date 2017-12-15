using IS403Project2.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IS403Project2.Models;
using System.Web.Security;

namespace IS403Project2.Controllers
{
    public class HomeController : Controller
    {
        private CalledToServeContext db = new CalledToServeContext();
        static string missionName = "";

        //GET: Home
        public ActionResult Login(string mission)
        {
            missionName = mission;
            ViewBag.errorMessage = "";
            return View();
        }

        //POST: Home
        [HttpPost]
        public ActionResult Login(FormCollection form, bool rememberMe = false)
        {
            String username = form["Username"].ToString();
            String password = form["Password"].ToString();

            var oAccount = db.Database.SqlQuery<Users>
            ("SELECT * FROM [Users] WHERE userEmail COLLATE Latin1_General_CS_AS = '" + username + "' AND " +
            "userPassword COLLATE Latin1_General_CS_AS = '" + password + "'").SingleOrDefault();

            if (oAccount != null)
            {
                FormsAuthentication.SetAuthCookie(username, rememberMe);

                Response.Cookies["AccountName"].Value = oAccount.userEmail;
                Response.Cookies["AccountName"].Expires = DateTime.Now.AddHours(1);

                return RedirectToAction("ViewMission", "Mission", new { mission = missionName });
            }
            else
            {
                //error message or reduce login count
                ViewBag.errorMessage = "INVALID USERNAME OR PASSWORD";
                return View();
            }
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your company's description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateUser([Bind(Include = "userID,userEmail,userPassword,userFirstName,userLastName")] Users users)
        {
            if (ModelState.IsValid)
            {
                db.User.Add(users);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(users);
        }
    }
}